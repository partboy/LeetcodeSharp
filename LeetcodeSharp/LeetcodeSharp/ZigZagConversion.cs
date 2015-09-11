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
            char[] newarray = new char[length];
            var width = GetMaxColumnIndex(length, numRows);
            var partWidth = numRows - 1;
            int index = 0;
            for (int row = 0; row < numRows; row++)
            {
                int positionInRow = 0;
                var positionInArray = PositionToIndex(row, positionInRow, numRows);
                if (positionInArray >= 0 && positionInArray < length)
                    newarray[index++] = s[positionInArray];

                while (positionInRow < width)
                {
                    var internal1 = numRows - 1 - row;
                    if (internal1 > 0)
                    {
                        positionInRow += internal1;
                        if (positionInRow >= width)
                            break;
                        else
                        {
                            var position1 = PositionToIndex(row, positionInRow, numRows);
                            if (position1 >= 0 && position1 < length)
                                newarray[index++] = s[position1];
                        }
                    }
                    var interval2 = row;
                    if (interval2 > 0)
                    {
                        positionInRow += interval2;
                        if (positionInRow >= width)
                            break;
                        else
                        {
                            var position2 = PositionToIndex(row, positionInRow, numRows);
                            if (position2 >= 0 && position2 < length)
                                newarray[index++] = s[position2];
                        }
                    }
                }
            }
            return new string(newarray);
        }

        private int GetMaxColumnIndex(int stringLength, int numRows)
        {
            var partNumbers = 2 * numRows - 2;
            var partCount = stringLength / partNumbers;
            var partsWidth = partCount * (numRows - 1);
            if (stringLength % partNumbers < numRows)
                return partsWidth + 1;
            else
                return partsWidth + 1 + stringLength % partNumbers - numRows;
        }

        private int PositionToIndex(int row, int column, int rowNumbers)
        {
            var partNumber = 2 * rowNumbers - 2;
            var partWidth = rowNumbers - 1;
            var previousPartCount = column / partWidth;
            var currentIndex = previousPartCount * partNumber - 1;
            var columnIndexInPart = column % partWidth;
            if (columnIndexInPart == 0)
                currentIndex += row + 1;
            else if (columnIndexInPart == rowNumbers - row - 1)
                currentIndex += rowNumbers + columnIndexInPart;
            else
                return -1;
            return currentIndex;
        }
    }
}
