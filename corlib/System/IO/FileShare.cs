using System;
using System.Runtime.InteropServices;

namespace System.IO
{
    /// <summary>Contains constants for controlling the kind of access other <see cref="T:System.IO.FileStream" /> objects can have to the same file.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum FileShare : int
    {
        /// <summary>Declines sharing of the current file. Any request to open the file (by this process or another process) will fail until the file is closed.</summary>
        None = 0,
        /// <summary>Allows subsequent opening of the file for reading. If this flag is not specified, any request to open the file for reading (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
        Read = 1,
        /// <summary>Allows subsequent opening of the file for writing. If this flag is not specified, any request to open the file for writing (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
        Write = 2,
        /// <summary>Allows subsequent opening of the file for reading or writing. If this flag is not specified, any request to open the file for reading or writing (by this process or another process) will fail until the file is closed. However, even if this flag is specified, additional permissions might still be needed to access the file.</summary>
        ReadWrite = 3,
        /// <summary>Allows subsequent deleting of a file.</summary>
        Delete = 4,
        /// <summary>Makes the file handle inheritable by child processes. This is not directly supported by Win32.</summary>
        Inheritable = 16
    }
}
