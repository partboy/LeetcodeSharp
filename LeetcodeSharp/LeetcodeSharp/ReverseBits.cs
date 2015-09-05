using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/reverse-bits/
    public class ReverseBits
    {
        public uint reverseBits(uint n)
        {
            bool[] list = new bool[32];
            int index = 0;
            while (n != 0)
            {
                list[index++] = n % 2 == 1;
                n = n >> 1;
            }
            uint result = 0;
            for (int i = 0; i < list.Length; i++)
            {
                result = (result << 1) + (list[i] ? (uint)1 : 0);
            }
            return result;
        }
    }
}
