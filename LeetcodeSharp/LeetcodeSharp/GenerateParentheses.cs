using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/generate-parentheses/
    //ref:https://leetcode.com/discuss/14436/concise-recursive-c-solution
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            AddParentheses(list, string.Empty, n, n);
            return list;
        }

        private void AddParentheses(List<string> list, string str, int left, int right)
        {
            if (left == 0 && right == 0)
            {
                list.Add(str);
                return;
            }
            if (left > 0)
                AddParentheses(list, str + "(", left - 1, right);
            if (right > left)
                AddParentheses(list, str + ")", left, right - 1);
        }
    }
}
