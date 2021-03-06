﻿using java.util.regex;
using System;
using System.Collections.Generic;

namespace CIL2Java.Globalization
{
    public static class Utils
    {
        // From https://closure-templates.googlecode.com/svn-history/r21/trunk/java/src/com/google/template/soy/internal/i18n/BidiUtils.java
        
        /**
        * A regular expression for matching right-to-left language codes.
        * See {@link #isRtlLanguage} for the design.
        */
        private static readonly Pattern RtlLocalesRe = Pattern.compile(
            "^(ar|dv|he|iw|fa|nqo|ps|sd|ug|ur|yi|.*[-_](Arab|Hebr|Thaa|Nkoo|Tfng))" +
            "(?!.*[-_](Latn|Cyrl)($|-|_))($|-|_)");

        /**
        * Check if a BCP 47 / III language code indicates an RTL language, i.e. either:
        * - a language code explicitly specifying one of the right-to-left scripts,
        *   e.g. "az-Arab", or<p>
        * - a language code specifying one of the languages normally written in a
        *   right-to-left script, e.g. "fa" (Farsi), except ones explicitly specifying
        *   Latin or Cyrillic script (which are the usual LTR alternatives).<p>
        * The list of right-to-left scripts appears in the 100-199 range in
        * http://www.unicode.org/iso15924/iso15924-num.html, of which Arabic and
        * Hebrew are by far the most widely used. We also recognize Thaana, N'Ko, and
        * Tifinagh, which also have significant modern usage. The rest (Syriac,
        * Samaritan, Mandaic, etc.) seem to have extremely limited or no modern usage
        * and are not recognized.
        * The languages usually written in a right-to-left script are taken as those
        * with Suppress-Script: Hebr|Arab|Thaa|Nkoo|Tfng  in
        * http://www.iana.org/assignments/language-subtag-registry,
        * as well as Sindhi (sd) and Uyghur (ug).
        * The presence of other subtags of the language code, e.g. regions like EG
        * (Egypt), is ignored.
        */
        public static bool isRtlLanguage(string languageString)
        {
            return languageString != null &&
                RtlLocalesRe.matcher(CIL2Java.Intrinsics.ToJavaString(languageString)).find();
        }
    }
}
