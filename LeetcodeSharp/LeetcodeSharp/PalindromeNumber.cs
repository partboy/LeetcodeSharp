using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/palindrome-number/
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else if (x < 10)
                return true;
            int length = 1;
            var number = x;
            while (number > 9)
            {
                number /= 10;
                length++;
            }
            int divider = PowerOfTen(length - 1);
            for (int i = 0; i < length / 2; i++)
            {
                var low = x % 10;
                var high = x / divider;
                if (low != high)
                    return false;
                else
                    x = (x - high * divider - low) / 10;
                divider = divider / 100;
            }
            return true;
        }

        private int PowerOfTen(int x)
        {
            int result = 1;
            for (int i = 0; i < x; i++)
                result *= 10;
            return result;
        }
    }
}
