using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/add-digits/
    class AddDigitsSolution
    {
        public int AddDigits(int num)
        {
            if (num == 0)
                return 0;
            else
            {
                var digit = num % 9;
                if (digit == 0)
                    return 9;
                else
                    return digit;
            }
        }
    }
}
