using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/implement-stack-using-queues/
    public class ImplementStackusingQueues
    {
        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();

        // Push element x onto stack.
        public void Push(int x)
        {
            if (queue2.Count > 0)
                queue2.Enqueue(x);
            else
                queue1.Enqueue(x);
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            if (queue1.Count > 0)
            {
                while (queue1.Count > 1)
                    queue2.Enqueue(queue1.Dequeue());
                queue1.Dequeue();
            }
            else if (queue2.Count > 0)
            {
                while (queue2.Count > 1)
                    queue1.Enqueue(queue2.Dequeue());
                queue2.Dequeue();
            }
        }

        // Get the top element.
        public int Top()
        {
            if (queue1.Count > 0)
            {
                while (queue1.Count > 1)
                    queue2.Enqueue(queue1.Dequeue());
                var item = queue1.Dequeue();
                queue2.Enqueue(item);
                return item;
            }
            else if (queue2.Count > 0)
            {
                while (queue2.Count > 1)
                    queue1.Enqueue(queue2.Dequeue());
                var item = queue2.Dequeue();
                queue1.Enqueue(item);
                return item;
            }
            return 0;
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return queue1.Count == 0 && queue2.Count == 0;
        }
    }
}
