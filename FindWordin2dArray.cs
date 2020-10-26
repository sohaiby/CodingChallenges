using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    static class FindWordin2dArray
    {
        static int stcRow, stcCol;
        static int[] x = { 0, 1, 1 };
        static int[] y = { 1, 0, 1 };

        public static void Run()
        {
            char[][] board = new char[][] { "soms".ToCharArray(), "oonp".ToCharArray(), "mmso".ToCharArray() };
            Console.WriteLine(wordCount(board, "som"));
        }

        static int wordCount(char[][] board, string word)
        {
            stcRow = board.Length;
            stcCol = board[0].Length;

            int count = 0;
            for (int row = 0; row < stcRow; row++)
            {
                for (int col = 0; col < stcCol; col++)
                {
                    if (searchArray(board, row, col, word))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static bool searchArray(char[][] grid, int row, int col, string word)
        {
            if (grid[row][col] != word[0])
            {
                return false;
            }

            int len = word.Length;

            for (int dir = 0; dir < 3; dir++)
            {
                int k, rd = row + x[dir], cd = col + y[dir];

                for (k = 1; k < len; k++)
                {
                    if (rd >= stcRow || rd < 0 || cd >= stcCol || cd < 0)
                    {
                        break;
                    }

                    if (grid[rd][cd] != word[k])
                    {
                        break;
                    }

                    rd += x[dir];
                    cd += y[dir];
                }

                if (k == len)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
