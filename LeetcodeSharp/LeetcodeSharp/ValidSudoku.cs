using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/valid-sudoku/
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            List<char> cells = new List<char>(9);
            //validate row
            for (int i = 0; i < 9; i++)
            {
                cells.Clear();
                for (int j = 0; j < 9; j++)
                    cells.Add(board[i, j]);
                if (!AreNineCellsValid(cells))
                    return false;
            }
            //validate column
            for (int i = 0; i < 9; i++)
            {
                cells.Clear();
                for (int j = 0; j < 9; j++)
                    cells.Add(board[j, i]);
                if (!AreNineCellsValid(cells))
                    return false;
            }
            //validate block
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells.Clear();
                    for (int m = 0; m < 3; m++)
                        for (int n = 0; n < 3; n++)
                            cells.Add(board[i * 3 + m, j * 3 + n]);
                    if (!AreNineCellsValid(cells))
                        return false;
                }
            }
            return true;
        }

        private bool AreNineCellsValid(IEnumerable<char> cells)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (var cell in cells)
            {
                if (cell == '.')
                    continue;
                else if (cell <= '9' && cell >= '1')
                {
                    if (!set.Add(cell))
                        return false;
                }
                //invalid char
                else
                    return false;
            }
            return true;
        }
    }
}
