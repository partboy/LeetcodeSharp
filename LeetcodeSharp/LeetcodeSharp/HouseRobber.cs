using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/house-robber/
    public class HouseRobber
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();

        public int Rob(int[] nums)
        {
            return RobInternal(nums, 0);
        }

        private int RobInternal(int[] nums, int index)
        {
            if (dict.ContainsKey(index))
                return dict[index];
            if (nums.Length == 0)
            {
                dict.Add(index, 0);
                return 0;
            }
            else if (nums.Length == 1)
            {
                dict.Add(index, nums[0]);
                return nums[0];
            }

            int rob1 = 0;
            int rob2 = 0;

            if (dict.ContainsKey(index + 2))
                rob1 = dict[index + 2];
            else
                rob1 = RobInternal(nums.Skip(2).ToArray(), index + 2);
            if (dict.ContainsKey(index + 3))
                rob2 = dict[index + 3];
            else
                rob2 = RobInternal(nums.Skip(3).ToArray(), index + 3);

            var value = Math.Max(nums[0] + rob1, nums[1] + rob2);
            if (!dict.ContainsKey(index))
                dict.Add(index, value);
            return value;
        }
    }
}
