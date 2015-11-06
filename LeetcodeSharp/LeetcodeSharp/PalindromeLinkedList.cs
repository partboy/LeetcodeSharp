using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/palindrome-linked-list/
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            bool isover = false;
            return Check(head, ref head, ref isover);
        }

        private bool Check(ListNode current, ref ListNode head, ref bool isover)
        {
            //start to compare, it's the end of the linkedlist
            if (current == null)
                return true;
            var result = Check(current.next, ref head, ref isover);
            if (result == false)
                return false;
            else if (isover)
                return true;
            else if (current.val != head.val)
                return false;
            else
            {
                if (head == current || head.next == current)
                    isover = true;
                else
                    head = head.next;
                return true;
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
