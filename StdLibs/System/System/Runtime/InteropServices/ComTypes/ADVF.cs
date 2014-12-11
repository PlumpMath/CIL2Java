using System;

namespace System.Runtime.InteropServices.ComTypes
{
    [FlagsAttribute()]
    public enum ADVF : int
    {
        ADVF_NODATA = 1,
        ADVF_PRIMEFIRST = 2,
        ADVF_ONLYONCE = 4,
        ADVF_DATAONSTOP = 64,
        ADVFCACHE_NOHANDLER = 8,
        ADVFCACHE_FORCEBUILTIN = 16,
        ADVFCACHE_ONSAVE = 32
    }
}
