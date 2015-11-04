using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/invert-binary-tree/
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            else if (root.left == null && root.right == null)
                return root;
            else
            {
                var left = InvertTree(root.left);
                var right = InvertTree(root.right);
                root.left = right;
                root.right = left;
                return root;
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
            public override string ToString()
            {
                return val.ToString();
            }
        }
    }
}
