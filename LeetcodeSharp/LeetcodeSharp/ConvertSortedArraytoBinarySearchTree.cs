using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    public class ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            return SortedArrayToBSTInternal(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBSTInternal(int[] nums, int low, int high)
        {
            if (low > high)
                return null;
            if (low == high)
                return new TreeNode(nums[low]);
            else
            {
                var mid = (low + high) / 2;
                TreeNode root = new TreeNode(nums[mid]);
                root.left = SortedArrayToBSTInternal(nums, low, mid - 1);
                root.right = SortedArrayToBSTInternal(nums, mid + 1, high);
                return root;
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
