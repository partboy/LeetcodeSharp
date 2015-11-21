using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/integer-to-roman/
    public class IntegertoRoman
    {
        public string IntToRoman(int num)
        {
            StringBuilder builder = new StringBuilder();
            while (num >= 1000)
            {
                num -= 1000;
                builder.Append('M');
            }
            while (num >= 100)
            {
                num -= 100;
                builder.Append('C');
            }
            while (num >= 10)
            {
                num -= 10;
                builder.Append('X');
            }
            while (num > 0)
            {
                num -= 1;
                builder.Append('I');
            }
            var result = builder.ToString();
            result = result.Replace("CCCCCCCCC", "CM");
            result = result.Replace("CCCCC", "D");
            result = result.Replace("CCCC", "CD");
            result = result.Replace("XXXXXXXXX", "XC");
            result = result.Replace("XXXXX", "L");
            result = result.Replace("XXXX", "XL");
            result = result.Replace("IIIIIIIII", "IX");
            result = result.Replace("IIIII", "V");
            result = result.Replace("IIII", "IV");
            return result;
        }
    }
}
