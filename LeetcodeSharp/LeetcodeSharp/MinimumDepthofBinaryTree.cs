using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/minimum-depth-of-binary-tree/
    public class MinimumDepthofBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right == null)
                return 1;
            else if (root.left == null)
                return MinDepth(root.right) + 1;
            else if (root.right == null)
                return MinDepth(root.left) + 1;
            else
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
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
