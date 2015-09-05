using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/pascals-triangle-ii/
    public class PascalTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] row = new int[rowIndex + 1];
            row[0] = 1;
            for (int round = 0; round <= rowIndex; round++)
            {
                for (int i = round; i >= 1; i--)
                {
                    row[i] = row[i] + row[i - 1];
                }
            }
            return row;
        }
    }
}
