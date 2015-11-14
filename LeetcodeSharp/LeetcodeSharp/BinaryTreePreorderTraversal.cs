using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/binary-tree-preorder-traversal/
    public class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            return PreorderTraversalIteratively(root);
        }

        private void PreorderTraversalRecursively(TreeNode root, IList<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            PreorderTraversalRecursively(root.left, list);
            PreorderTraversalRecursively(root.right, list);
        }

        private IList<int> PreorderTraversalIteratively(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var list = new List<int>();
            var p = root;
            while (p != null)
            {
                list.Add(p.val);
                if (p.left != null)
                {
                    if (p.right != null)
                        stack.Push(p);
                    p = p.left;
                }
                else if (p.right != null)
                    p = p.right;
                else
                {
                    if (stack.Count > 0)
                        p = stack.Pop().right;
                    else
                        break;
                }
            }
            return list;
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
