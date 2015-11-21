using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/maximum-subarray/
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int max = nums[0];
            int maxthisround = 0;
            int sum = 0;
            int index = 0;
            while (index < nums.Length)
            {
                sum = 0;
                maxthisround = nums[index];
                for (; index < nums.Length; index++)
                {
                    var newsum = sum + nums[index];
                    if (newsum <= 0)
                    {
                        max = Math.Max(max, maxthisround);
                        index++;
                        break;
                    }
                    else
                    {
                        maxthisround = Math.Max(maxthisround, newsum);
                        sum = newsum;
                    }
                }
            }
            return Math.Max(max, maxthisround);
        }
    }
}

