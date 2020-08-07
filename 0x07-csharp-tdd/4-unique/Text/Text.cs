﻿using System;
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

            if (s is null)
            {
                return -1;
            }
            if (s is "")
            {
                return -1;
            }
            for (int j = 0; j < s.Length;)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                        {
                            j++;
                            break;
                        }
                        if (i == s.Length -1 && s[i] != s[j])
                        {
                            return (j +1);
                        }
                    }
                }
            }
            return -1;
        }
    }
}
