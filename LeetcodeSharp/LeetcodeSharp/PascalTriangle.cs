using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/pascals-triangle/
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>(numRows);
            for (int index = 0; index < numRows; index++)
            {
                int[] row = new int[index + 1];
                row[0] = 1;
                row[index] = 1;
                if (triangle.Count > 0)
                {
                    var lastrow = triangle.Last();
                    for (int i = 1; i < index; i++)
                        row[i] = lastrow[i - 1] + lastrow[i];
                }
                triangle.Add(row);
            }
            return triangle;
        }
    }
}
