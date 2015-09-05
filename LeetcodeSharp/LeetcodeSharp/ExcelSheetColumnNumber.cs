using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/excel-sheet-column-number/
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                number = number * 26;
                number += s[i] - 'A' + 1;
            }
            return number;
        }
    }
}
