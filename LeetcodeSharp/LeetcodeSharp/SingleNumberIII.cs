using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/single-number-iii/
    class SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                    set.Remove(num);
                else
                    set.Add(num);
            }
            return set.ToArray();
        }
    }
}
