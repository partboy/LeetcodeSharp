using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/valid-parentheses/
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            const char left1 = '(';
            const char left2 = '{';
            const char left3 = '[';
            const char right1 = ')';
            const char right2 = '}';
            const char right3 = ']';

            Stack<char> stack = new Stack<char>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == left1 || s[i] == left2 || s[i] == left3)
                    stack.Push(s[i]);
                else if (s[i] == right1)
                {
                    if (stack.Count == 0 || stack.Pop() != left1)
                        return false;
                }
                else if (s[i] == right2)
                {
                    if (stack.Count == 0 || stack.Pop() != left2)
                        return false;
                }
                else if (s[i] == right3)
                {
                    if (stack.Count == 0 || stack.Pop() != left3)
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
