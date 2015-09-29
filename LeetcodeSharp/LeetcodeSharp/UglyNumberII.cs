using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/ugly-number-ii/
    public class UglyNumberII
    {
        public int NthUglyNumber(int n)
        {
            switch (n)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                case 4:
                    return 4;
                case 5:
                    return 5;
            }
            List<int> sortedUglyNumbers = new List<int>(n);
            sortedUglyNumbers.AddRange(new int[] { 1, 2, 3, 4, 5 });
            for (int i = 5; i < n; i++)
            {
                var nextUglyNumber = NextUglyNumber(sortedUglyNumbers);
                sortedUglyNumbers.Add(nextUglyNumber);
            }
            return sortedUglyNumbers.Last();
        }

        private int NextUglyNumber(List<int> sortedArray)
        {
            if (sortedArray == null || !sortedArray.Any())
                return 1;
            var lastNumber = sortedArray.Last();
            int max2 = FindMinLargerNumber(sortedArray, 0, sortedArray.Count - 1, lastNumber / 2);
            int max3 = FindMinLargerNumber(sortedArray, 0, sortedArray.Count - 1, lastNumber / 3);
            int max5 = FindMinLargerNumber(sortedArray, 0, sortedArray.Count - 1, lastNumber / 5);
            return Math.Min(Math.Min(max2 * 2, max3 * 3), max5 * 5);
        }

        private int FindMinLargerNumber(List<int> sortedArray, int start, int end, int num)
        {
            if (sortedArray[0] > num)
                return sortedArray[0];
            if (start == end)
            {
                if (sortedArray[start] > num)
                    return num;
                else
                    return -1;
            }
            else if (start + 1 == end)
            {
                if (sortedArray[start] > num)
                    return sortedArray[start];
                else if (sortedArray[end] > num)
                    return sortedArray[end];
                else
                    return -1;
            }
            else
            {
                var mid = (start + end) / 2;
                if (sortedArray[mid] < num)
                    return FindMinLargerNumber(sortedArray, mid, end, num);
                else if (sortedArray[mid] > num)
                    return FindMinLargerNumber(sortedArray, start, mid, num);
                else
                    return sortedArray[mid + 1];
            }
        }
    }
}
