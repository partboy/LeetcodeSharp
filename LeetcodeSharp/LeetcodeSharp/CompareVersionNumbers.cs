using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/compare-version-numbers/
    class CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            var numbers1 = version1.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers2 = version2.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var minlength = Math.Min(numbers1.Length, numbers2.Length);
            for (int i = 0; i < minlength; i++)
            {
                var v1 = int.Parse(numbers1[i]);
                var v2 = int.Parse(numbers2[i]);
                if (v1 == v2)
                    continue;
                else if (v1 > v2)
                    return 1;
                else if (v1 < v2)
                    return -1;
            }
            if (numbers1.Length == numbers2.Length)
                return 0;
            else if (numbers1.Length > numbers2.Length)
            {
                if (numbers1.Skip(minlength).All(x => int.Parse(x) == 0))
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (numbers2.Skip(minlength).All(x => int.Parse(x) == 0))
                    return 0;
                else
                    return -1;
            }
        }
    }
}
