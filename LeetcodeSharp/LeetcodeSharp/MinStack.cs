using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/min-stack/
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> minstack = new Stack<int>();

        public void Push(int x)
        {
            stack.Push(x);
            if (minstack.Count == 0 || minstack.Peek() >= x)
                minstack.Push(x);
        }

        public void Pop()
        {
            var item = stack.Pop();
            if (minstack.Peek() == item)
                minstack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minstack.Peek();
        }
    }
}
