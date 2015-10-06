using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/remove-element/
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int tail = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    while (true)
                    {
                        if (tail <= i)
                            return i;
                        if (nums[tail] != val)
                        {
                            nums[i] = nums[tail--];
                            break;
                        }
                        else
                            tail--;
                    }

                }
                if (tail <= i)
                    return i + 1;
            }
            return 0;
        }
    }
}
