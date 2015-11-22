using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/gray-code/
    public class GrayCodeSolution
    {
        public IList<int> GrayCode(int n)
        {
            int count = 1;
            for (int i = 0; i < n; i++)
                count = count << 1;
            int[] list = new int[count];
            int power = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < power; j++)
                    list[power + j] = list[power - 1 - j] + power;
                power *= 2;
            }
            return list;
        }
    }
}
