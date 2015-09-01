using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/happy-number/
    class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n < 1)
                return false;
            else if (n == 1)
                return true;
            else
            {
                var cycle = new List<int>();
                while (true)
                {
                    var list = new List<int>();
                    while (n >= 10)
                    {
                        list.Add(n % 10);
                        n = n / 10;
                    }
                    list.Add(n);
                    n = list.Sum(x => x * x);
                    if (cycle.Contains(n))
                        break;
                    else
                        cycle.Add(n);
                }
                return n == 1;
            }
        }
    }
}
