using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class StringtoInteger
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            var value = GetVaildString(str);
            if (value == null)
                return 0;
            else if (value.Length == 1 && (value[0] == '+' || value[0] == '-'))
                return 0;
            else
            {
                if (value[0] == '-')
                    return Parse(value.Substring(1), false);
                else if (value[0] == '+')
                    return Parse(value.Substring(1), true);
                else
                    return Parse(value, true);
            }
        }

        private int Parse(string value, bool positive)
        {
            if (value.Length > 10 || (value.Length == 9 && value[0] > '2'))
                return positive ? int.MaxValue : int.MinValue;
            else
            {
                long result = 0;
                for (int i = 0; i < value.Length; i++)
                    result = result * 10 + (value[i] - '0');
                if (positive && result > int.MaxValue)
                    return int.MaxValue;
                else if (!positive && result > Math.Abs((long)int.MinValue))
                    return int.MinValue;
                else
                    return positive ? (int)result : (int)result * -1;
            }
        }

        private string GetVaildString(string str)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (c >= '0' && c <= '9')
                {
                    if (start == -1)
                        start = i;
                    end = i;
                }
                else if (c == '+' || c == '-')
                {
                    if (start == -1)
                        start = i;
                    else
                        return null;
                }
                else if (char.IsWhiteSpace(c))
                {
                    if (start != -1)
                        break;
                }
                else
                {
                    if (start != -1)
                        break;
                    else
                        return null;
                }
            }
            if (start < 0 || end < 0 || start > end)
                return null;
            else
                return str.Substring(start, end - start + 1);
        }
    }
}
