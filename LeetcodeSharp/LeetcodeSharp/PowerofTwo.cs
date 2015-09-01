using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/power-of-two/
    class PowerofTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n < 1)
                return false;
            else
            {
                while ((n & 0x1) == 0)
                    n = n >> 1;
                return n == 1;
            }
        }
    }
}
