using System;

namespace Text
{
    /// <summary>
    /// Represents string class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// counts number of words in string
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>count or 0</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0 )
                return (0);

            int count = 1;

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    count += 1;
            }
            if (char.IsUpper(s[0]))
                count -= 1;
            return (count);
        }
    }
}