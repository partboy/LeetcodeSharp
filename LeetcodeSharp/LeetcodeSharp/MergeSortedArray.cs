using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/merge-sorted-array/
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums2.Length == 0 || n == 0)
                return;
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                    nums1[i] = nums2[i];
                return;
            }

            var pointer1 = m - 1;
            var pointer2 = n - 1;
            while (true)
            {
                if (nums1[pointer1] > nums2[pointer2])
                {
                    nums1[pointer1 + pointer2 + 1] = nums1[pointer1];
                    pointer1--;
                    if (pointer1 < 0)
                    {
                        for (int i = 0; i <= pointer2; i++)
                            nums1[i] = nums2[i];
                        return;
                    }
                }
                else if (nums1[pointer1] < nums2[pointer2])
                {
                    nums1[pointer1 + pointer2 + 1] = nums2[pointer2];
                    pointer2--;
                    if (pointer2 < 0)
                        return;
                }
                else
                {
                    nums1[pointer1 + pointer2 + 1] = nums1[pointer1];
                    nums1[pointer1 + pointer2] = nums1[pointer1];
                    pointer1--;
                    pointer2--;
                    if (pointer2 < 0)
                        return;
                    if (pointer1 < 0)
                    {
                        for (int i = 0; i <= pointer2; i++)
                            nums1[i] = nums2[i];
                        return;
                    }
                }
            }
        }
    }
}
