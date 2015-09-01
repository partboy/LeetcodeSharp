using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/rotate-array/
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            var n = nums.Length;
            var newk = k % n;
            var newarray = nums.ToList();
            for (int i = 0; i < newk; i++)
            {
                nums[i] = newarray[n - newk + i];
            }
            for (int i = 0; i < n - newk; i++)
            {
                nums[newk + i] = newarray[i];
            }
        }
    }
}
