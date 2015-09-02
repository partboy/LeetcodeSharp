using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class ContainsDuplicateSolutionII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length < 2 || k < 1)
                return false;
            k = Math.Min(nums.Length - 1, k);
            var hashset = new HashSet<int>();
            for (int i = 0; i < k + 1; i++)
            {
                if (!hashset.Add(nums[i]))
                    return true;
            }
            var count = nums.Length - k;
            for (int index = 1; index < count; index++)
            {
                hashset.Remove(nums[index - 1]);
                if (!hashset.Add(nums[index + k]))
                    return true;
            }
            return false;
        }

    }
}
