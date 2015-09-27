using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/isomorphic-strings/
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s == t)
                return true;
            //key is char in t, value is char in s
            Dictionary<char, char> mapping = new Dictionary<char, char>();
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (mapping.ContainsKey(s[i]))
                {
                    if (t[i] != mapping[s[i]])
                        return false;
                }
                else
                {
                    mapping.Add(s[i], t[i]);
                    if (!set.Add(t[i]))
                        return false;
                }
            }
            return true;
        }
    }
}
