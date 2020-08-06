using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Class for strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a palindrome
        /// </summary>
        /// <param name="s">given string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string s)
        {
            string reversed;

            if (s == null)
                return (false);

            var shortened = String.Join("", s.Where(char.IsLetterOrDigit));

            char[] arr = shortened.ToCharArray();

            Array.Reverse(arr);
            reversed = new string(arr);

            return shortened.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
