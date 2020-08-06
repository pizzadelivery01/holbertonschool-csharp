using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// string class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// finds non unique char
        /// </summary>
        /// <param name="s">string to be evaluated</param>
        /// <returns>index or -1</returns>
        public static int UniqueChar(string s)
        {
            int occurs = 0;
            int n = 1;

            if (s is null)
            {
                return -1;
            }
            if (s is "")
            {
                return -1;
            }
            foreach (var ch in s)
            {
                for (int i = 0; i < s.Length; i++){
                    if (s[i] == ch){
                        occurs += 1;
                    };
                }
                if (occurs == 1){
                    return n;
                }
                occurs = 0;
                n += 1;
            }
            return -1;
        }
    }
}
