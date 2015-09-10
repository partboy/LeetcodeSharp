using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/zigzag-conversion/
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (s == string.Empty)
                return string.Empty;

            if (s.Length == 1 || numRows == 1)
                return s;

            var length = s.Length;
            char[,] array = new char[numRows, length / 2 + 1];
            int column = 0;
            for (int i = 0; i < length; )
            {
                for (int r = 0; i < length && r < numRows; )
                {
                    array[r, column] = s[i];
                    i++;
                    r++;
                }
                for (int r = numRows - 2; i < length && r > 0; )
                {
                    column++;
                    array[r, column] = s[i];
                    i++;
                    r--;
                }
                column++;
            }
            StringBuilder builder = new StringBuilder(length);
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < length / 2 + 1; c++)
                {
                    var character = array[r, c];
                    if (character != '\0')
                    {
                        builder.Append(character);
                    }
                }
            }
            return builder.ToString();
        }
    }
}
