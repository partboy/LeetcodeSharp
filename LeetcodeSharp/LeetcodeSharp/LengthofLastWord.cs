using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    public class LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            const char space = ' ';
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            int lastIndex = s.Length - 1;
            while (s[lastIndex] == space)
                lastIndex--;
            for (int i = 0; i <= lastIndex; i++)
            {
                if (s[lastIndex - i] == space)
                    return i;
            }
            return lastIndex + 1;
        }
    }
}
