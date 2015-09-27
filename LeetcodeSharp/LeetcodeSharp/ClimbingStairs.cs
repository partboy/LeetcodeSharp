using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class ClimbingStairsSolution
    {
        public int ClimbStairs(int n)
        {
            if (n < 1)
                return 0;
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            else
                return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            if (n == 1) return 1;
            else if (n == 2) return 2;
            int num1 = 1;
            int num2 = 2;
            int i = 3;
            while (i <= n)
            {
                var sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                i++;
            }
            return num2;
        }
    }
}
