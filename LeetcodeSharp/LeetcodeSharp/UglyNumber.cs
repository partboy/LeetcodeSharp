using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/ugly-number/
    public class UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num <= 0)
                return false;
            while (num % 2 == 0)
                num = num / 2;
            while (num % 3 == 0)
                num = num / 3;
            while (num % 5 == 0)
                num = num / 5;
            if (num == 1)
                return true;
            else
                return false;
        }
    }
}
