using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    public class LCAofBST
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return GetEquivalentNode(root, p, q);
        }

        private TreeNode GetEquivalentNode(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            else if (root == p || root == q)
                return root;
            var left = GetEquivalentNode(root.left, p, q);
            var right = GetEquivalentNode(root.right, p, q);
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
                return root;
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
