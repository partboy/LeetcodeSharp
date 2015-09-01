using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/contains-duplicate/
    class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return false;
            HashSet<int> set = new HashSet<int>(nums);
            return set.Count < nums.Length;
        }
    }
}
