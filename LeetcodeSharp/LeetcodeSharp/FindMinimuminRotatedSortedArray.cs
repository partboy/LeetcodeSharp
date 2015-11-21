using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    public class FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start + 1 < end)
            {
                var target = nums[start];
                var mid = (start + end) / 2;
                if (nums[mid] > target)
                    start = mid;
                else
                    end = mid;
            }
            return Math.Min(nums[0], nums[end]);
        }
    }
}
