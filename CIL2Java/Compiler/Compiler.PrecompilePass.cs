﻿using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void RenameMethod(InterMethod method, string newName)
        {
            method.NewName = newName;

            foreach (InterType derivedType in typesToCompile.Where(T => T.BaseType == method.DeclaringType))
            {
                InterMethod derivedMethod = derivedType.Methods.Where(M => M.IsSame(method)).FirstOrDefault();

                if (derivedMethod != null)
                    RenameMethod(derivedMethod, newName);
            }
        }

        private void AddCtorsForMappedExceptions()
        {
            var exceptionsWithMapped = typesToCompile.Where(T => T.JavaExceptions.Length > 0);
            foreach (InterType exception in exceptionsWithMapped)
            {
                int lastCount = typesToCompile.Count;

                TypeDefinition typeDef = loadedModules.Select(M => M.GetType(exception.Fullname))
                    .Where(T => T != null).FirstOrDefault();
                exception.JavaExceptions.ForEach(e =>
                {
                    var method = typeDef.Methods.Where(M => ((M.IsConstructor) && (M.Parameters.Count == 1) &&
                        (M.Parameters[0].ParameterType.FullName == e))).FirstOrDefault();
                    if (method != null)
                        ((IResolver)this).Resolve(method, null);
                });

                if (lastCount != typesToCompile.Count)
                {
                    AddCtorsForMappedExceptions();
                    break;
                }
            }
        }

        private void PrecompilePass()
        {
            Messages.Verbose("Precompile pass...");

            IResolver resolver = (IResolver)this;

            if (Program.OverflowCheck)
                resolver.Resolve(ClassNames.OverflowExceptionTypeName);

            if (typesToCompile
                .Where(T => T.IsDelegate)
                .Any(T => T.Methods.Where(M => M.Name == ClassNames.DelegateBeginInvokeMethodName).Count() > 0))
                    ((IResolver)this).Resolve(ClassNames.SystemRuntimeRemotingMessagingAsyncResult.ClassName);
            if (Program.MethodPointersType == MethodPointerImplementation.Standart)
                ((IResolver)this).Resolve(ClassNames.CIL2JavaVESMethodPointersGlobal.ClassNames);

            Messages.Verbose("  Finding and adding overloading methods...");
            for (int i = 0; i < typesToCompile.Count; i++)
                typesToCompile[i].CheckOverloadingMethods(this, loadedModules.Where(MD => MD.Name == "c2j_mscorlib.dll").FirstOrDefault());

            Messages.Verbose("  Renaming newslot methods...");
            foreach (InterType type in typesToCompile)
            {
                var newSlotMethods = type.Methods.Where(M => (!M.IsConstructor) && (M.IsNewSlot || !M.IsVirtual));

                foreach (InterMethod method in newSlotMethods)
                {
                    bool isOverrideMethod = false;
                    InterType baseType = type.BaseType;
                    while (baseType != null)
                    {
                        if (baseType.Methods.Where(M => M.IsSame(method)).Count() > 0)
                        {
                            isOverrideMethod = true;
                            break;
                        }

                        baseType = baseType.BaseType;
                    }

                    if (isOverrideMethod)
                        RenameMethod(method, ClassNames.RenamedMethodPrefix + method.Name);
                }
            }

            //Special: adding default ctor for System.ValueType
            if (typesToCompile.Where(T => T.Fullname == "System.ValueType").Count() > 0)
            {
                ((IResolver)this).Resolve(loadedModules.Where(M => M.Name.Contains("corlib")).FirstOrDefault()
                    .GetType("System.ValueType").Methods.Where(M => (M.IsConstructor && M.Parameters.Count == 0))
                    .FirstOrDefault(), null);
            }

            //Special: adding ctors for Mapped exceptions
            AddCtorsForMappedExceptions();

            Messages.Verbose("  Checking for non standart overriding...");
            foreach (InterType type in typesToCompile)
            {
                foreach (InterMethod method in type.Methods)
                {
                    bool needRename = typesToCompile.Where(T =>
                        T.Methods.Where(M =>
                            M.Overrides.Contains(method)).Count() > 0).Count() > 0;

                    if (needRename)
                    {
                        method.NewName = ClassNames.RenamedMethodPrefix + method.DeclaringType.Fullname + "_" + method.Name;

                        Messages.Verbose("    Type method `{0}` renamed to `{1}`.", method.ToString(), method.NewName);
                    }
                }
            }
        }
    }
}
