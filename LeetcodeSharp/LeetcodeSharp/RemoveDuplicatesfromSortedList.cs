using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    public class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            var node = head;
            while (node.next != null)
            {
                if (node.val == node.next.val)
                    node.next = node.next.next;
                else
                    node = node.next;
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
