using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal/
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();
            List<IList<int>> result = new List<IList<int>>();
            var last = new List<TreeNode>() { root };
            while (true)
            {
                var currentNodes = new List<TreeNode>();
                var currentResult = last.Select(x => x.val).ToList();
                result.Add(currentResult);
                foreach (var item in last)
                {
                    if (item.left != null)
                        currentNodes.Add(item.left);
                    if (item.right != null)
                        currentNodes.Add(item.right);
                }
                if (currentNodes.Count == 0)
                    break;
                else
                    last = currentNodes;
            }
            return result;
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
