using System;
using System.Linq;

namespace Text
{
    /// <summary> Class string </summary>
    public class Str
    {
        /// <summary> Determines if an string its palindrome.false Return true or false </summary>
        public static bool IsPalindrome(string s)
        {
            string pali = new string(s.Reverse().ToArray());
            return s.SequenceEqual(s);

        }
    }
}
