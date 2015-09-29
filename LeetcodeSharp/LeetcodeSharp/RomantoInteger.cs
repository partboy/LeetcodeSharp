using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/roman-to-integer/
    public class RomantoInteger
    {
        public int RomanToInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int value = 0;

            for (int i = 0; i < s.Length; )
            {
                if (i == s.Length - 1)
                {
                    value += RomanCharToInt(s[i]);
                    break;
                }
                else
                {
                    if (s[i] == 'I' && s[i + 1] == 'V')
                    {
                        value += 4;
                        i += 2;
                    }
                    else if (s[i] == 'I' && s[i + 1] == 'X')
                    {
                        value += 9;
                        i += 2;
                    }
                    else if (s[i] == 'X' && s[i + 1] == 'L')
                    {
                        value += 40;
                        i += 2;
                    }
                    else if (s[i] == 'X' && s[i + 1] == 'C')
                    {
                        value += 90;
                        i += 2;
                    }
                    else if (s[i] == 'C' && s[i + 1] == 'D')
                    {
                        value += 400;
                        i += 2;
                    }
                    else if (s[i] == 'C' && s[i + 1] == 'M')
                    {
                        value += 900;
                        i += 2;
                    }
                    else
                    {
                        value += RomanCharToInt(s[i]);
                        i++;
                    }
                }
            }
            return value;
        }

        private int RomanCharToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
