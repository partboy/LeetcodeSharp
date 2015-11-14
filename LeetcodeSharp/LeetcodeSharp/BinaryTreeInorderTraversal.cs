using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            return InorderTraversalIteratively(root);
        }

        private IList<int> InorderTraversalIteratively(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var list = new List<int>();
            var p = root;
            while (p != null)
            {
                if (p.left != null)
                {
                    stack.Push(p);
                    p = p.left;
                }
                else
                {
                    list.Add(p.val);
                    if (p.right != null)
                        p = p.right;
                    else if (stack.Count == 0)
                        break;
                    else
                    {
                        bool end = true;
                        while (stack.Count > 0)
                        {
                            p = stack.Pop();
                            list.Add(p.val);
                            if (p.right != null)
                            {
                                end = false;
                                p = p.right;
                                break;
                            }
                        }
                        if (end)
                            break;
                    }
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
