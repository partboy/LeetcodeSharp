using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/unique-paths/
    public class UniquePathsSolution
    {
        //PICK N FROM M+N C(n+m,n)=(m+n)!/n!/m!
        public int UniquePaths(int m, int n)
        {
            if (m < 1 || n < 1)
                return 0;
            if (m == 1 || n == 1)
                return 1;
            int p = m <= n ? n - 1 : m - 1;
            int q = m <= n ? m - 1 : n - 1;
            long value1 = 1;
            long value2 = 1;
            for (int i = 1; i <= q; i++)
            {
                value1 *= i;
                value2 *= (p + i);
            }
            return (int)(value2 / value1);
        }
    }
}
