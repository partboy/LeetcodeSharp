using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/same-tree/
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null)
                return q == null;
            else if (q == null)
                return p == null;
            else if (p.val == q.val)
            {
                if ((p.right == null && q.right != null) || (p.right != null && q.right == null))
                    return false;
                else
                    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else
                return false;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
