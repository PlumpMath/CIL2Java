﻿using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private enum ExpectType
        {
            None,
            Any,
            Primitive,
            Reference,
            ByRef,
            Boxed
        }

        private ExpectType GetExpectType(InterParameter param)
        {
            return GetExpectType(param.Type);
        }

        private ExpectType GetExpectType(InterType type)
        {
            if (type.IsByRef)
                return ExpectType.ByRef;
            else if (type.IsPrimitive)
                return ExpectType.Primitive;
            else
                return ExpectType.Reference;
        }

        private ExpectType GetExpectType(InterField fld)
        {
            return GetExpectType(fld.FieldType);
        }

        private ExpectType GetExpectType(JavaPrimitiveType type)
        {
            if (type == JavaPrimitiveType.Ref)
                return ExpectType.Reference;
            else
                return ExpectType.Primitive;
        }

        private void TranslateType(InterType type, ExpectType expected, object tag)
        {
            if (expected == ExpectType.Any)
                return;

            if (expected == ExpectType.None)
                codeGenerator.AddPop(JavaHelpers.InterTypeToJavaPrimitive(type), tag);

            if ((expected == ExpectType.Boxed) && (type.IsPrimitive))
                BoxType(type, tag);
        }
    }
}
