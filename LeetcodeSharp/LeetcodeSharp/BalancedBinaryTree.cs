using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/balanced-binary-tree/
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            int depth;
            return DepthOfBalancedTree(root, out depth);
        }

        private bool DepthOfBalancedTree(TreeNode root, out int depth)
        {
            if (root.left == null && root.right == null)
            {
                depth = 1;
                return true;
            }
            else if (root.left == null)
            {
                int rightdepth;
                var isbalanced = DepthOfBalancedTree(root.right, out rightdepth);
                if (!isbalanced || rightdepth > 1)
                {
                    depth = -1;
                    return false;
                }
                else
                {
                    depth = rightdepth + 1;
                    return true;
                }
            }
            else if (root.right == null)
            {
                int leftdepth;
                var isbalanced = DepthOfBalancedTree(root.left, out leftdepth);
                if (!isbalanced || leftdepth > 1)
                {
                    depth = -1;
                    return false;
                }
                else
                {
                    depth = leftdepth + 1;
                    return true;
                }
            }
            else
            {
                int leftdepth;
                int rightdepth;
                var isleftbalanced = DepthOfBalancedTree(root.left, out leftdepth);
                if (isleftbalanced == false)
                {
                    depth = -1;
                    return false;
                }
                var isrightbalanced = DepthOfBalancedTree(root.right, out rightdepth);
                if (isrightbalanced == false || Math.Abs(leftdepth - rightdepth) > 1)
                {
                    depth = -1;
                    return false;
                }
                else
                {
                    depth = Math.Max(leftdepth, rightdepth) + 1;
                    return true;
                }
            }
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

