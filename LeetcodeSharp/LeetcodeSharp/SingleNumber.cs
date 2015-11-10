using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/single-number/
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            int number = 0;
            foreach (var num in nums)
                number = number ^ num;
            return number;
        }
    }
}
