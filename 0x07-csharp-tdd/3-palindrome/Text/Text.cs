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
            String reversed;

            if (s is null)
            {
                return false;
            }
            var shortend = String.Join("", s.Where(char.IsLetterOrDigit));
            char[] arr = shortend.ToCharArray();
            Array.Reverse(arr);
            reversed = new String(arr);

            return reversed.Equals(s, StringComparison.OrdinalIgnoreCase);
        }
    }
}
