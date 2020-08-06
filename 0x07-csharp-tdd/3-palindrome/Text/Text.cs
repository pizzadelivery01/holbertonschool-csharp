using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// class string 
    /// </summary>
    public class Str
    {
        /// <summary>
        /// checks for palindromes
        /// </summary>
        /// <param name="s">sting to check</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string s)
        {
            string reversed = new string(s.Reverse().ToArray());
            return reversed.SequenceEqual(s);
        }
    }
}
