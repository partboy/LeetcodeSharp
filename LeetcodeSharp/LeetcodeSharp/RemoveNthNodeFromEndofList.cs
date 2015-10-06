using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    public class RemoveNthNodeFromEndofList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode t = head;
            ListNode p = head;
            if (head == null)
                return null;
            else if (head.next == null && n > 0)
                return null;
            for (int i = 0; i < n - 1; i++)
                t = t.next;
            if (t.next == null)
                return head.next;
            else
                t = t.next;
            while (true)
            {
                if (t.next == null)
                {
                    if (p.next == head)
                        return head.next;
                    else
                        p.next = p.next.next;
                    break;
                }
                else
                {
                    p = p.next;
                    t = t.next;
                }
            }
            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
