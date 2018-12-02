using System.Linq;
using System.Net;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="string"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the first letter of string to upper case
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <returns>String with the first letter in upper case</returns>
        public static string FirstLetterToUpper(this string str)
        {
            if (str == null) return null;
            return str.Length > 1 ? char.ToUpper(str[0]) + str.Substring(1) : str.ToUpper();
        }

        /// <summary>
        /// "Full" trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)
        /// </summary>
        /// <param name="str">String to full trim</param>
        /// <returns>"Fully" trimmed string</returns>
        public static string TrimAndMergeLines(this string str)
        {
            str = str.Replace("\r\n", "\r").Replace("\n", "\r");
            var lines = str.Split('\r');
            str = string.Join(" ", lines.Select(l => l.Trim())).Trim();
            return str;
        }

        /// <summary>
        /// HTML encodes the string
        /// </summary>
        /// <param name="str">String to encode</param>
        /// <returns>HTML encoded string</returns>
        public static string HtmlEncode(this string str)
        {
            return WebUtility.HtmlEncode(str);
        }

        /// <summary>
        /// HTML decodes the string
        /// </summary>
        /// <param name="str">String to decode</param>
        /// <returns>HTML decoded string</returns>
        public static string HtmlDecode(this string str)
        {
            return WebUtility.HtmlDecode(str);
        }
    }
}
