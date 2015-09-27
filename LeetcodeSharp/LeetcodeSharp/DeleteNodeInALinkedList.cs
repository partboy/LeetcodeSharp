using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/delete-node-in-a-linked-list/
    public class DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
