using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/bulls-and-cows/
    public class BullsandCows
    {
        public string GetHint(string secret, string guess)
        {
            int countA = 0;
            int[] secretList = new int[10];
            int[] guessList = new int[10];
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                    countA++;
                else
                {
                    secretList[secret[i] - '0']++;
                    guessList[guess[i] - '0']++;
                }
            }
            if (countA == secret.Length)
                return string.Format("{0}A0B", countA);
            int countB = 0;
            for (int i = 0; i < 10; i++)
                countB += Math.Min(secretList[i], guessList[i]);
            return string.Format("{0}A{1}B", countA, countB);
        }
    }
}
