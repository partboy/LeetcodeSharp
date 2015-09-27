using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MaximumDepthofBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
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