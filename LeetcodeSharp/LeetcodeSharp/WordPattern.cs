using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/word-pattern/
    public class WordPatternSolution
    {
        public bool WordPattern(string pattern, string str)
        {
            if (string.IsNullOrWhiteSpace(pattern) || string.IsNullOrWhiteSpace(str))
                return false;

            Dictionary<char, string> mapping = new Dictionary<char, string>(26);
            int index = 0;
            foreach (var c in pattern)
            {
                if (mapping.ContainsKey(c))
                {
                    if (CompareWord(str, index, mapping[c]))
                        index += mapping[c].Length + 1;
                    else
                        return false;
                }
                else
                {
                    if (index >= str.Length)
                        return false;
                    var word = GetWord(str, index);
                    if (mapping.Values.Contains(word))
                        return false;
                    else
                    {
                        mapping.Add(c, word);
                        index += word.Length + 1;
                    }
                }
            }
            if (index == str.Length + 1)
                return true;
            else
                return false;
        }

        private string GetWord(string str, int index)
        {
            for (int i = index; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                    return str.Substring(index, i - index);
            }
            return str.Substring(index);
        }

        private bool CompareWord(string str, int index, string comparedStr)
        {
            if (comparedStr.Length > str.Length - index)
                return false;
            else
            {
                for (int i = 0; i < comparedStr.Length; i++)
                {
                    if (comparedStr[i] != str[i + index])
                        return false;
                }
                return true;
            }
        }
    }
}
