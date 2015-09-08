using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/First-Bad-Version/
    public class FirstBadVersionSolution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            if (IsBadVersion(0))
                return 0;
            return BinarySearchFirstBadVersion(0, n);
        }

        private int BinarySearchFirstBadVersion(int head, int tail)
        {
            if (head == tail - 1)
                return tail;
            int mid = (int)(((long)head + (long)tail) / 2);
            bool isbad = IsBadVersion(mid);
            if (isbad)
                return BinarySearchFirstBadVersion(head, mid);
            else
                return BinarySearchFirstBadVersion(mid, tail);
        }
    }

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return version >= 1702766719;
        }
    }
}
