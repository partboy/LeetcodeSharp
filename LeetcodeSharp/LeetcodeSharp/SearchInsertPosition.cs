using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/search-insert-position/
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
                return 0;
            else
            {
                int start = 0;
                int end = nums.Length - 1;
                while (start <= end)
                {
                    var mid = (start + end) / 2;
                    if (nums[mid] == target)
                        return mid;
                    else if (nums[mid] < target)
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
                return start;
            }
        }
    }
}
