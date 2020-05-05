using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary> Represents class of operations </summary>
    public class Operations
    {
        /// <summary> Return the max int in a list </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }
            int max = nums.Max();
            return (max);
        }
    }
}
