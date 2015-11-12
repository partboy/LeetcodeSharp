using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/range-sum-query-immutable/
    public class RangeSumQueryImmutable
    {
        private int[] sums;

        public RangeSumQueryImmutable(int[] nums)
        {
            sums = new int[nums.Length + 1];
            for (int i = 1; i < sums.Length; i++)
                sums[i] = sums[i - 1] + nums[i - 1];
        }

        public int SumRange(int i, int j)
        {
            return sums[j + 1] - sums[i];
        }
    }
}
