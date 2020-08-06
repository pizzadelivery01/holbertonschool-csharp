using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// class of operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// finds max integer
        /// </summary>
        /// <param name="nums">list on numbers</param>
        /// <returns>max int</returns>
        public static int Max(List<int> nums)
        {
            if (nums is null)
            {
                return 0;
            }
            if (nums.Count <= 0)
            {
                return 0;
            }
            else
            {
                int max = 0;
                foreach (var item in nums)
                {
                    if (item > max)
                    {
                        max = item;
                    }

                }
                return max;
            }
        }
    }
}
