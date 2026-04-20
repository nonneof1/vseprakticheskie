using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _11prakreal
{
    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            TextInfo ti = new CultureInfo("ru-RU", false).TextInfo;
            return ti.ToTitleCase(str);
        }
    }
}