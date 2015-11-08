using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/implement-strstr/
    public class ImplementstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null)
                return -1;
            else if (needle == string.Empty)
                return 0;
            else if (needle.Length > haystack.Length)
                return -1;
            else
            {
                for (int i = 0; i < haystack.Length && haystack.Length - i >= needle.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        if (needle.Length > 1)
                        {
                            for (int j = 1; j < needle.Length; j++)
                            {
                                if (haystack[i + j] != needle[j])
                                    break;
                                else if (j == needle.Length - 1)
                                    return i;
                                else
                                    continue;
                            }
                        }
                        else
                            return i;
                    }
                }
                return -1;
            }
        }
    }
}
