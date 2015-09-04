using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/valid-anagram/
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null)
                return false;
            if (s == t)
                return true;
            if (s.Length != t.Length)
                return false;
            var dictionaryS = s.ToCharArray().GroupBy(x => x).ToDictionary(k => k.Key, v => v.Count());
            var dictionaryT = t.ToCharArray().GroupBy(x => x).ToDictionary(k => k.Key, v => v.Count());
            if (dictionaryS.Count != dictionaryT.Count)
                return false;
            foreach (var itemS in dictionaryS)
            {
                if (dictionaryT.ContainsKey(itemS.Key) && dictionaryT[itemS.Key] == itemS.Value)
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
