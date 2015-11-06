using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/binary-tree-paths/
    public class BinaryTreePathsSolution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();
            if (root == null)
                return result;
            else
                return GetPaths(root);

        }

        private IList<string> GetPaths(TreeNode node)
        {
            if (node.left == null && node.right == null)
                return new List<string>() { node.val.ToString() };
            else if (node.left == null)
                return GetPaths(node.right).Select(x => string.Format("{0}->{1}", node.val, x)).ToList();
            else if (node.right == null)
                return GetPaths(node.left).Select(x => string.Format("{0}->{1}", node.val, x)).ToList();
            else
            {
                var left = GetPaths(node.left).Select(x => string.Format("{0}->{1}", node.val, x));
                var right = GetPaths(node.right).Select(x => string.Format("{0}->{1}", node.val, x));
                return left.Concat(right).ToList();
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
