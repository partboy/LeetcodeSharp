using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            else
            {
                var p1 = head;
                var p2 = head.next;
                var p3 = head.next.next;
                p1.next = null;
                while (p2 != null)
                {
                    p2.next = p1;
                    if (p3 == null)
                        break;
                    p1 = p2;
                    p2 = p3;
                    p3 = p2.next;
                }
                return p2;
            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public override string ToString()
            {
                return val.ToString();
            }
        }
    }
}
