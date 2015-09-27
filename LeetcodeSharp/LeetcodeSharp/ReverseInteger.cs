using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/reverse-integer/
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            List<int> list = new List<int>();
            while (x != 0)
            {
                list.Add(x % 10);
                x /= 10;
            }
            long number = 0;
            for (int i = 0; i < list.Count; i++)
            {
                number = number * 10;
                number += list[i];
            }
            if (number > int.MaxValue || number < int.MinValue)
                return 0;
            return (int)number;
        }
    }
}
