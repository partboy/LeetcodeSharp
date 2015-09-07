using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/excel-sheet-column-title/
    public class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            List<char> title = new List<char>(7);
            while (n > 0)
            {
                var remainder = n % 26;
                char letter = remainder == 0 ? 'Z' : (char)('A' - 1 + remainder);
                title.Add(letter);
                n = n - (remainder == 0 ? 26 : remainder);
                n = n / 26;
            }
            title.Reverse();
            return new String(title.ToArray());
        }
    }
}
