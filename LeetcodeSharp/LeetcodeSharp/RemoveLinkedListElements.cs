using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/remove-linked-list-elements/
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
                head = head.next;
            if (head == null)
                return null;
            else if (head.next == null)
                return head;
            else
            {
                var p = head;
                while (p.next.next != null)
                {
                    if (p.next.val == val)
                        p.next = p.next.next;
                    else
                        p = p.next;
                }
                if (p.next.val == val)
                    p.next = null;
                return head;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
