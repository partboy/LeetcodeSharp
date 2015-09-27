using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return nums.Length;
            int ph = nums[0];
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    nums[i - 1] = ph;
                    count++;
                }
            }
            int firstPossible = 1;
            for (int i = 1; i < nums.Length - count; i++)
            {
                if (nums[i] == ph)
                {
                    for (int j = Math.Max(i + 1, firstPossible); j < nums.Length; j++)
                    {
                        if (nums[j] != ph)
                        {
                            var temp = nums[j];
                            nums[j] = ph;
                            nums[i] = temp;
                            firstPossible = j + 1;
                            break;
                        }
                    }
                }
            }
            return nums.Length - count;
        }
    }
}
