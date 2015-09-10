using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/add-binary/
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            var lengthA = a.Length;
            var lengthB = b.Length;
            var maxlength = lengthA > lengthB ? lengthA : lengthB;
            var minlength = lengthA < lengthB ? lengthA : lengthB;

            char[] binary = new char[maxlength];
            bool carry = false;
            for (int i = 0; i < minlength; i++)
            {
                if (a[lengthA - 1 - i] == '1' && b[lengthB - 1 - i] == '1')
                {
                    binary[binary.Length - 1 - i] = carry ? '1' : '0';
                    carry = true;
                }
                else if (a[lengthA - 1 - i] == '0' && b[lengthB - 1 - i] == '0')
                {
                    binary[binary.Length - 1 - i] = carry ? '1' : '0';
                    carry = false;
                }
                else
                    //carry doesn't change
                    binary[binary.Length - 1 - i] = carry ? '0' : '1';
            }
            var longerString = lengthA > lengthB ? a : b;
            for (int i = 0; i < maxlength - minlength; i++)
            {
                var c = longerString[maxlength - minlength - 1 - i];
                if (c == '1')
                    binary[maxlength - minlength - 1 - i] = carry ? '0' : '1';
                else
                {
                    binary[maxlength - minlength - 1 - i] = carry ? '1' : '0';
                    carry = false;
                }
            }
            return string.Format("{0}{1}", carry ? "1" : null, new string(binary));
        }
    }
}