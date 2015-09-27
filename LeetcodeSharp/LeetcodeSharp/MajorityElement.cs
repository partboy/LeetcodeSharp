using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/majority-element/
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            return nums.GroupBy(x => x).ToDictionary(k => k.Key, v => v.Count()).First(kv => kv.Value > nums.Length / 2).Key;
        }
    }
}
