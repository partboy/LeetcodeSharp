using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/valid-palindrome/
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s == string.Empty)
                return true;

            int head = 0;
            int tail = s.Length - 1;
            while (head < tail)
            {
                char headItem = '\0';
                char tailItem = '\0';
                while (head < tail)
                {
                    var h = s[head];
                    if (h >= 'A' && h <= 'Z')
                    {
                        headItem = h;
                        break;
                    }
                    else if (h >= '0' && h <= '9')
                    {
                        headItem = h;
                        break;
                    }
                    else if (h >= 'a' && h <= 'z')
                    {
                        headItem = (char)(h - 32);
                        break;
                    }
                    else
                        head++;
                }
                while (head < tail)
                {
                    var t = s[tail];
                    if (t >= 'A' && t <= 'Z')
                    {
                        tailItem = t;
                        break;
                    }
                    else if (t >= '0' && t <= '9')
                    {
                        tailItem = t;
                        break;
                    }
                    else if (t >= 'a' && t <= 'z')
                    {
                        tailItem = (char)(t - 32);
                        break;
                    }
                    else
                        tail--;
                }
                if (head == tail)
                    return true;
                else if (head < tail)
                {
                    if (headItem != tailItem)
                        return false;
                    else
                    {
                        head++;
                        tail--;
                    }
                }
            }
            return true;
        }
    }
}
