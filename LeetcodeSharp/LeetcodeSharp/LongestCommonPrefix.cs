using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs.Any(x => string.IsNullOrEmpty(x)))
                return string.Empty;
            var minlength = strs.Min(x => x.Length);
            StringBuilder prefixBuilder = new StringBuilder();
            for (int i = 0; i < minlength; i++)
            {
                var charactar = strs[0][i];
                if (strs.All(x => x[i] == charactar))
                    prefixBuilder.Append(charactar);
                else
                    break;
            }
            return prefixBuilder.ToString();
        }
    }
}
