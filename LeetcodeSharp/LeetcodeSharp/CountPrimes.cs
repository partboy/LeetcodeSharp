using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/count-primes/
    class CountPrimesSolution
    {
        public int CountPrimes(int n)
        {
            if (n < 3)
                return 0;
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    count++;
            }
            return count;
        }

        private bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            var root = (int)Math.Sqrt(n);
            for (int i = 2; i <= root; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
