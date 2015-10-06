using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/factorial-trailing-zeroes/
    public class FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            //the count of the trailing zero is equivalent to the count of 5 which the numbers < n contain.
            if (n < 5)
                return 0;
            return CountOfNumber(n, 5);
        }

        private int CountOfNumber(int n, int number)
        {
            int count = 0;
            int currentN = n;
            do
            {
                var newN = currentN / number;
                count += newN;
                currentN = newN;
            }
            while (currentN >= 5);
            return count;
        }
    }
}
