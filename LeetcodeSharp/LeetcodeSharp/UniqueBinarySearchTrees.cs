using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/unique-binary-search-trees/
    public class UniqueBinarySearchTrees
    {
        public int NumTrees(int n)
        {
            if (n < 2) return 1;
            int[] N = new int[n + 1];
            N[1] = 1;
            N[2] = 2;
            for (int x = 3; x <= n; x++)
                N[x] = N[x - 1] * 2 + Enumerable.Range(1, x - 2).Sum(index => N[index] * N[x - index - 1]);
            return N[n];
        }
    }
}
