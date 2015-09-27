using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/move-zeroes/
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1)
                return;
            int nextNonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nextNonZeroIndex = i + 1;
                    continue;
                }
                else
                {
                    var index = FindNextNonZero(nums, nextNonZeroIndex);
                    if (index == -1)
                        return;
                    else
                    {
                        Swap(nums, i, index);
                        nextNonZeroIndex = index + 1;
                    }
                }
            }
        }

        private int FindNextNonZero(int[] nums, int startIndex)
        {
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    return i;
            }
            return -1;
        }

        private void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
