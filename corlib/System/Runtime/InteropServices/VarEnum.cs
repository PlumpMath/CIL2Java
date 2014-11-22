using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates how to marshal the array elements when an array is marshaled from managed to unmanaged code as a <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum VarEnum : int
    {
        /// <summary>Indicates that a value was not specified.</summary>
        VT_EMPTY = 0,
        /// <summary>Indicates a null value, similar to a null value in SQL.</summary>
        VT_NULL = 1,
        /// <summary>Indicates a short integer.</summary>
        VT_I2 = 2,
        /// <summary>Indicates a long integer.</summary>
        VT_I4 = 3,
        /// <summary>Indicates a float value.</summary>
        VT_R4 = 4,
        /// <summary>Indicates a double value.</summary>
        VT_R8 = 5,
        /// <summary>Indicates a currency value.</summary>
        VT_CY = 6,
        /// <summary>Indicates a DATE value.</summary>
        VT_DATE = 7,
        /// <summary>Indicates a BSTR string.</summary>
        VT_BSTR = 8,
        /// <summary>Indicates an IDispatch pointer.</summary>
        VT_DISPATCH = 9,
        /// <summary>Indicates an SCODE.</summary>
        VT_ERROR = 10,
        /// <summary>Indicates a Boolean value.</summary>
        VT_BOOL = 11,
        /// <summary>Indicates a VARIANT far pointer.</summary>
        VT_VARIANT = 12,
        /// <summary>Indicates an IUnknown pointer.</summary>
        VT_UNKNOWN = 13,
        /// <summary>Indicates a decimal value.</summary>
        VT_DECIMAL = 14,
        /// <summary>Indicates a char value.</summary>
        VT_I1 = 16,
        /// <summary>Indicates a byte.</summary>
        VT_UI1 = 17,
        /// <summary>Indicates an unsignedshort.</summary>
        VT_UI2 = 18,
        /// <summary>Indicates an unsignedlong.</summary>
        VT_UI4 = 19,
        /// <summary>Indicates a 64-bit integer.</summary>
        VT_I8 = 20,
        /// <summary>Indicates an 64-bit unsigned integer.</summary>
        VT_UI8 = 21,
        /// <summary>Indicates an integer value.</summary>
        VT_INT = 22,
        /// <summary>Indicates an unsigned integer value.</summary>
        VT_UINT = 23,
        /// <summary>Indicates a C style void.</summary>
        VT_VOID = 24,
        /// <summary>Indicates an HRESULT.</summary>
        VT_HRESULT = 25,
        /// <summary>Indicates a pointer type.</summary>
        VT_PTR = 26,
        /// <summary>Indicates a SAFEARRAY. Not valid in a VARIANT.</summary>
        VT_SAFEARRAY = 27,
        /// <summary>Indicates a C style array.</summary>
        VT_CARRAY = 28,
        /// <summary>Indicates a user defined type.</summary>
        VT_USERDEFINED = 29,
        /// <summary>Indicates a null-terminated string.</summary>
        VT_LPSTR = 30,
        /// <summary>Indicates a wide string terminated by null.</summary>
        VT_LPWSTR = 31,
        /// <summary>Indicates a user defined type.</summary>
        VT_RECORD = 36,
        /// <summary>Indicates a FILETIME value.</summary>
        VT_FILETIME = 64,
        /// <summary>Indicates length prefixed bytes.</summary>
        VT_BLOB = 65,
        /// <summary>Indicates that the name of a stream follows.</summary>
        VT_STREAM = 66,
        /// <summary>Indicates that the name of a storage follows.</summary>
        VT_STORAGE = 67,
        /// <summary>Indicates that a stream contains an object.</summary>
        VT_STREAMED_OBJECT = 68,
        /// <summary>Indicates that a storage contains an object.</summary>
        VT_STORED_OBJECT = 69,
        /// <summary>Indicates that a blob contains an object.</summary>
        VT_BLOB_OBJECT = 70,
        /// <summary>Indicates the clipboard format.</summary>
        VT_CF = 71,
        /// <summary>Indicates a class ID.</summary>
        VT_CLSID = 72,
        /// <summary>Indicates a simple, counted array.</summary>
        VT_VECTOR = 4096,
        /// <summary>Indicates a SAFEARRAY pointer.</summary>
        VT_ARRAY = 8192,
        /// <summary>Indicates that a value is a reference.</summary>
        VT_BYREF = 16384
    }
}
