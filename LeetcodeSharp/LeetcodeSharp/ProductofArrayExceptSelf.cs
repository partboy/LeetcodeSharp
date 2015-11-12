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
            int countZero = 0;
            int indexOfZero = -1;
            var products = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (countZero == 1)
                        return products;
                    else
                    {
                        countZero++;
                        indexOfZero = i;
                    }
                }
            }
            if (countZero == 1)
            {
                products[indexOfZero] = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != indexOfZero)
                        products[indexOfZero] *= nums[i];
                }
                return products;
            }
            products[0] = 1;
            for (int i = 1; i < nums.Length; i++)
                products[0] *= nums[i];
            for (int i = 1; i < nums.Length; i++)
                products[i] = nums[i - 1] * (products[i - 1] / nums[i]);
            return products;
        }
    }
}
