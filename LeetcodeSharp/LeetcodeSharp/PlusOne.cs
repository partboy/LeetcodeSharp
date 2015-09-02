using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/plus-one/
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            int pointer = digits.Length - 1;
            while (true)
            {
                if (digits[pointer] < 9)
                {
                    digits[pointer]++;
                    return digits;
                }
                else
                {
                    //reach the head
                    if (pointer == 0)
                    {
                        digits[pointer] = 0;
                        var newdigits = new int[digits.Length + 1];
                        newdigits[0] = 1;
                        for (int i = 0; i < digits.Length; i++)
                            newdigits[i + 1] = digits[i];
                        return newdigits;
                    }
                    else
                    {
                        digits[pointer] = 0;
                        pointer--;
                    }
                }
            }
        }
    }
}
