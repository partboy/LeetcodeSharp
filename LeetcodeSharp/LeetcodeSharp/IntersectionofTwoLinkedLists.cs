using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/intersection-of-two-linked-lists/
    public class IntersectionofTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            var countA = Count(headA);
            var countB = Count(headB);
            if (countA > countB)
                for (int i = 0; i < countA - countB; i++)
                    headA = headA.next;
            else if (countA < countB)
                for (int i = 0; i < countB - countA; i++)
                    headB = headB.next;
            ListNode result = null;
            while (headA != null)
            {
                if (headA.val == headB.val)
                {
                    if (result == null)
                        result = headA;
                }
                else
                    result = null;
                headA = headA.next;
                headB = headB.next;
            }
            return result;
        }

        private int Count(ListNode head)
        {
            if (head == null)
                return 0;
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
