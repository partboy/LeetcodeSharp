using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/summary-ranges/
    class SummaryRangesSolution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 0)
                return new List<string>();
            else if (nums.Length == 1)
                return new List<string> { nums[0].ToString() };
            var result = new List<string>();
            var sorted = nums.OrderBy(x => x);
            int previousNumber = nums[0];
            int head = nums[0];
            for (int i = 1; i < nums.Length; )
            {
                //continuous
                if (nums[i] - previousNumber == 1)
                {
                    //last number
                    if (i == nums.Length - 1)
                    {
                        result.Add(string.Format("{0}->{1}", head, nums[i]));
                        break;
                    }
                    else
                    {
                        previousNumber = nums[i];
                        i++;
                    }
                }
                else
                {
                    if (head == previousNumber)
                        result.Add(string.Format("{0}", head));
                    else
                        result.Add(string.Format("{0}->{1}", head, previousNumber));
                    if (i <= nums.Length - 2)
                    {
                        head = nums[i];
                        previousNumber = nums[i];
                        i++;
                    }
                    //not continuous, the current item is the last number
                    else if (i == nums.Length - 1)
                    {
                        result.Add(string.Format("{0}", nums[nums.Length - 1]));
                        break;
                    }
                }
            }
            return result;
        }
    }
}
