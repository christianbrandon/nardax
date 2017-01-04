using System;
using System.ComponentModel;
<<<<<<< HEAD
using System.Text;
=======
using System.Text.RegularExpressions;
>>>>>>> 458d2e8140c9a03e7a9e45d5ef86d69e3ff3dbbf

namespace Nardax
{
    public static class StringExtensions
    {
        // Klipp av en sträng från vänster

        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }

        // Klipp av en sträng från höger

        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }

        public static string RepeatMe(this string value, int times)
        {
            var sb = new StringBuilder();

            for(var i=0; i<times; i++)
            {
                sb.Append(value);
            }
            return sb.ToString();
        }
            

        public static string RemoveWhiteChars(this string value)
        {
            return Regex.Replace(value, "\\s", "");
        }

    }
}
