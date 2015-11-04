using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/symmetric-tree/
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricIteratively(root);
        }

        private bool IsSymmetricIteratively(TreeNode root)
        {
            if (root == null)
                return true;
            else if (root.left == null && root.right == null)
                return true;
            else if (root.left == null || root.right == null)
                return false;
            else
            {
                if (root.left.val != root.right.val)
                    return false;
                else
                {
                    var left = new List<TreeNode>() { root.left };
                    var right = new List<TreeNode>() { root.right };
                    while (true)
                    {
                        var lastleft = left.Where(x => x != null).ToList();
                        var lastright = right.Where(x => x != null).ToList();
                        left = lastleft.Select(x => x.left).Concat(lastleft.Select(x => x.right)).ToList();
                        right = lastright.Select(x => x.left).Concat(lastright.Select(x => x.right)).ToList();
                        if (left.All(x => x == null) && right.All(x => x == null))
                            return true;
                        for (int i = 0; i < left.Count; i++)
                        {
                            var l = left[i];
                            var r = right[left.Count - i - 1];
                            if (l == null && r == null)
                                continue;
                            else if (l != null && r != null && l.val == r.val)
                                continue;
                            else
                                return false;
                        }
                    }
                }
            }
        }

        private bool IsSymmetricRecursively(TreeNode root)
        {
            if (root == null)
                return true;
            else if (root.left == null && root.right == null)
                return true;
            else if (root.left == null || root.right == null)
                return false;
            else
                return AreTwoBSTSymmetric(root.left, root.right);
        }

        private bool AreTwoBSTSymmetric(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            else if (node1 == null || node2 == null)
                return false;
            else
            {
                if (node1.val != node2.val)
                    return false;
                else
                    return AreTwoBSTSymmetric(node1.left, node2.right) && AreTwoBSTSymmetric(node1.right, node2.left);
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
