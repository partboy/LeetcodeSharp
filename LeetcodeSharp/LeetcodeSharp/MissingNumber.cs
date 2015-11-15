using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/missing-number/
    public class MissingNumberSolution
    {
        public int MissingNumber(int[] nums)
        {
            long sum = 0;
            int max = 0;
            bool zerofound = false;
            foreach (var num in nums)
            {
                sum += num;
                if (num > max)
                    max = num;
                if (num == 0)
                    zerofound = true;
            }
            if (!zerofound)
                return 0;
            long newsum = max * (max + 1) / 2;
            if (newsum > sum)
                return (int)(newsum - sum);
            else
                return max + 1;
        }
    }
}
