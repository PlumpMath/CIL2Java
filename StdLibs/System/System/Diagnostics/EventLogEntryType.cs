using System;

namespace System.Diagnostics
{
    public enum EventLogEntryType : int
    {
        Error = 1,
        Warning = 2,
        Information = 4,
        SuccessAudit = 8,
        FailureAudit = 16
    }
}
