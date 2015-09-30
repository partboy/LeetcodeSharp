using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;
            ListNode head = null;
            var node1 = l1;
            var node2 = l2;
            if (node1.val <= node2.val)
            {
                head = node1;
                node1 = node1.next;
            }
            else
            {
                head = node2;
                node2 = node2.next;
            }
            ListNode current = head;
            while (true)
            {
                if (node1 == null && node2 == null)
                    return head;
                else if (node1 == null)
                {
                    current.next = node2;
                    current = current.next;
                    return head;
                }
                else if (node2 == null)
                {
                    current.next = node1;
                    current = current.next;
                    return head;
                }
                else
                {
                    if (node1.val <= node2.val)
                    {
                        current.next = node1;
                        node1 = node1.next;
                        current = current.next;
                    }
                    else
                    {
                        current.next = node2;
                        node2 = node2.next;
                        current = current.next;
                    }
                }
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
