using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/implement-queue-using-stacks/
    public class ImplementQueueusingStacks
    {
        private Stack<int> pushstack = new Stack<int>();
        private Stack<int> popstack = new Stack<int>();

        // Push element x to the back of queue.
        public void Push(int x)
        {
            pushstack.Push(x);
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            if (popstack.Count > 0)
                popstack.Pop();
            else
            {
                while (pushstack.Count > 1)
                    popstack.Push(pushstack.Pop());
                if (pushstack.Count == 1)
                    pushstack.Pop();
            }
        }

        // Get the front element.
        public int Peek()
        {
            if (popstack.Count > 0)
                return popstack.Peek();
            else
            {
                while (pushstack.Count > 0)
                    popstack.Push(pushstack.Pop());
                return popstack.Peek();
            }
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return popstack.Count == 0 && pushstack.Count == 0;
        }
    }
}
