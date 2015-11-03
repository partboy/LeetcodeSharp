using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/nim-game/
    public class NimGame
    {
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}
