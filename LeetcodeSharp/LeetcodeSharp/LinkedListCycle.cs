using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/linked-list-cycle/
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            var slowpoint = head;
            var fastpoint = head;
            while (true)
            {
                if (fastpoint.next != null && fastpoint.next.next != null)
                {
                    fastpoint = fastpoint.next.next;
                    slowpoint = slowpoint.next;
                    if (fastpoint == slowpoint)
                        return true;
                }
                else
                    return false;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
