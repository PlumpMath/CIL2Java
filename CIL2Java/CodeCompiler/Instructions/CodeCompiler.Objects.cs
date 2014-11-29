﻿using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileNewobj(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if (ctor.DeclaringType.IsArray)
                CompileNewmultiarray(e, expect);
            else
            {
                Java.Constants.Class declTypeClassRef = new Java.Constants.Class(
                    namesController.TypeNameToJava(ctor.DeclaringType.Fullname));

                codeGenerator
                    .Add(Java.OpCodes._new, declTypeClassRef, e)
                    .Add(Java.OpCodes.dup, null, e);

                CompileCall(e, expect);
            }
        }

        private void CompileStobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.IsPrimitive)
            {
                // From ECMA-335, III.4.29
                // The stobj instruction copies the value src to the address dest. If typeTok is not
                // a generic parameter and either a reference type or a built-in value class, then 
                // the stind instruction provides a shorthand for the stobj instruction.
                CompileStind(e, expect);
            }
            else
            {
                //TODO: CompileStobj
            }
        }

        private void CompileLdobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if ((operand.IsPrimitive) && (e.Arguments[0].Code == ILCode.Ldloc) &&
                (((ILVariable)e.Arguments[0].Operand).Name == "this"))
            {
                //Special treatment. Value for primitive types
                codeGenerator
                    .Add(Java.OpCodes.aload_0, null, e)
                    .Add(Java.OpCodes.getfield, new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.CILBoxType), "value",
                        namesController.GetFieldDescriptor(operand)), e);
            }
        }

        private void CompileIsinst(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            //  dup
            //  instanceof operand
            //  ifne :end
            //  pop
            //  aconst_null
            //:end

            string endLabel = rnd.Next().ToString() + "end";

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(GetBoxType(operand)));

            codeGenerator
                .Add(Java.OpCodes.dup, null, e)
                .Add(Java.OpCodes.instanceof, operandRef, e)
                .Add(Java.OpCodes.ifne, endLabel, e)
                .Add(Java.OpCodes.pop, null, e)
                .Add(Java.OpCodes.aconst_null, null, e)
                .Label(endLabel);
        }

        private void CompileBox(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Boxed);
        }

        private void CompileUnbox_Any(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            string boxType = GetBoxType(operand);

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(boxType));

            

            Java.Constants.MethodRef valueRef = new Java.Constants.MethodRef(operandRef.Value,
                Utils.GetJavaTypeName(operand.PrimitiveType) + "Value",
                "()" + namesController.GetFieldDescriptor(operand));

            codeGenerator
                .Add(Java.OpCodes.checkcast, operandRef, e)
                .Add(Java.OpCodes.invokevirtual, valueRef, e);
        }
    }
}
