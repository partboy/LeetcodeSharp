using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/product-of-array-except-self/
    public class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];
            if (nums.Length == 1)
                return nums;
            var products = new int[nums.Length];
            int current = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                products[i] = current;
                current *= nums[i];
            }
            current = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                products[i] *= current;
                current *= nums[i];
            }
            return products;
        }
    }
}
