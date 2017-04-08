using System;

namespace Recursion
{
    public class SudokuSolver
    {
        public bool Solve(int[,] sudoku, int row = 0, int col = 0)
        {
            if (col == 9)
            {
                col = 0;
                row++;

                if (row == 9)
                {
                    PrintSudoku(sudoku);
                    return true;
                }
            }

            if (sudoku[row, col] > 0)
            {
                return Solve(sudoku, row, col + 1);
            }

            for (int number = 1; number <= 9; number++)
            {
                var canPlaceNumber = true;

                for (int i = 0; i < 9; i++)
                {
                    var boxCheckX = row / 3 * 3 + i / 3;
                    var boxCheckY = col / 3 * 3 + i % 3;
                    if (sudoku[row, i] == number || sudoku[i, col] == number || sudoku[boxCheckX, boxCheckY] == number)
                    {
                        canPlaceNumber = false;
                        break;
                    }
                }

                if (!canPlaceNumber)
                {
                    continue;
                }

                if (canPlaceNumber == true)
                {
                    sudoku[row, col] = number;
                }

                if (Solve(sudoku, row, col + 1))
                {
                    return true;
                }

                sudoku[row, col] = 0;
            }

            return false;
        }

        private void PrintSudoku(int[,] sudoku)
        {
            for (int row = 0; row < sudoku.GetLength(0); row++)
            {
                for (int col = 0; col < sudoku.GetLength(1); col++)
                {
                    Console.Write($"{sudoku[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
