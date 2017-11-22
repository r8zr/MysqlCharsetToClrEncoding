using System;
using System.Data;
using System.Linq;
using System.Text;

namespace MySqlCharsetToClrEncoding
{
    public static class MySqlCharsetToClrEncoding
    {
	// References:
	// https://dev.mysql.com/doc/refman/5.5/en/charset-charsets.html
        // https://stackoverflow.com/questions/7320847/get-encoding-list-in-net-1-1
        public static Encoding Convert(string charset)
        {
            if (string.IsNullOrWhiteSpace(charset))
                return Encoding.UTF8;

            try
            {
                if (string.Equals(charset, "cp850", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(850);
                if (string.Equals(charset, "cp852", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(852);
                if (string.Equals(charset, "cp866", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(866);
                if (string.Equals(charset, "cp932", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(932);
                if (string.Equals(charset, "cp1250", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(1250);
                if (string.Equals(charset, "cp1251", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(1251);
                if (string.Equals(charset, "latin1", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(1252);
                if (string.Equals(charset, "cp1256", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(1256);
                if (string.Equals(charset, "cp1257", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(1257);
                if (string.Equals(charset, "latin2", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("iso-8859-2");
                if (string.Equals(charset, "greek", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("iso-8859-7");
                if (string.Equals(charset, "hebrew", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("iso-8859-8");
                if (string.Equals(charset, "latin5", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("iso-8859-9");
                if (string.Equals(charset, "latin7", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("iso-8859-13");
                if (string.Equals(charset, "gb2312", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("gb2312");
                if (string.Equals(charset, "macce", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("x-mac-ce");
                if (string.Equals(charset, "macroman", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("macintosh");
                if (string.Equals(charset, "sjis", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("shift_jis");
                if (string.Equals(charset, "euckr", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("euc-kr");
                if (string.Equals(charset, "ujis", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("euc-jp");
                if (string.Equals(charset, "gb2312", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("hz-gb-2312");
                if (string.Equals(charset, "koi8r", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("koi8-r");
                if (string.Equals(charset, "koi8u", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("koi8-u");
                if (string.Equals(charset, "big5", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding("big5");
                if (string.Equals(charset, "utf32", StringComparison.OrdinalIgnoreCase))
                    return Encoding.UTF32;
                if (string.Equals(charset, "utf16", StringComparison.OrdinalIgnoreCase))
                    return Encoding.Unicode;
                if (string.Equals(charset, "ascii", StringComparison.OrdinalIgnoreCase))
                    return Encoding.ASCII;
            }
            catch (Exception)
            {
                // Can't get encoding for charset
            }
            return Encoding.UTF8;
        }
    }
}
