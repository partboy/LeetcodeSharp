using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/path-sum/
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            else if (root.right == null && root.left == null && root.val == sum)
                return true;
            else
                return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
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
