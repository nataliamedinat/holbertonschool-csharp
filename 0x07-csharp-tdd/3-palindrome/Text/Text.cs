using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary> Class string </summary>
    public class Str
    {
        /// <summary> Determines if an string its palindrome.false Return true or false </summary>
        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");
            string pali = new string(s.Reverse().ToArray());
            if (s == pali)
                return true;
            else
                return false;

        }
    }
}
