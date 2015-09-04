using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/number-of-1-bits/
    public class Numberof1Bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                if (n % 2 == 1)
                    count++;
                n = n / 2;
            }
            return count;
        }
    }
}
