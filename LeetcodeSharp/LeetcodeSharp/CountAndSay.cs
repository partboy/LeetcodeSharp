using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/count-and-say/
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            string initial = "1";
            for (int i = 1; i < n; i++)
                initial = Next(initial);
            return initial;
        }

        private string Next(string number)
        {
            if (number.Length == 1)
                return string.Format("1{0}", number[0]);
            else
            {
                StringBuilder builder = new StringBuilder(number.Length * 2);
                int count = 1;
                for (int i = 1; i < number.Length; i++)
                {
                    if (number[i] == number[i - 1])
                        count++;
                    else
                    {
                        builder.AppendFormat("{0}{1}", count, number[i - 1]);
                        count = 1;
                    }
                }
                builder.AppendFormat("{0}{1}", count, number[number.Length - 1]);
                return builder.ToString();
            }
        }
    }
}
