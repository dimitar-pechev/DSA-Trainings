using System;

namespace Recursion
{
    public class MatrixPathFinder
    {
        private const char ExitSymbol = 'E';
        private const char PathTrailSymbol = 'o';
        private const char DeadEndSymbol = 'x';
        private const char EmptyCellSymbol = '.';

        public void PrintPathBetweenTwoCells(char[,] matrix, int row = 0, int col = 0)
        {
            if (row == matrix.GetLength(0) || col == matrix.GetLength(1) || row < 0 || col < 0)
            {
                return;
            }

            if (matrix[row, col] == ExitSymbol)
            {
                PrintMatrix(matrix);
                return;
            }

            if (matrix[row, col] == PathTrailSymbol || matrix[row, col] == DeadEndSymbol)
            {
                return;
            }

            matrix[row, col] = PathTrailSymbol;

            // right
            PrintPathBetweenTwoCells(matrix, row, col + 1);

            // down
            PrintPathBetweenTwoCells(matrix, row + 1, col);

            // left
            PrintPathBetweenTwoCells(matrix, row, col - 1);

            // up
            PrintPathBetweenTwoCells(matrix, row - 1, col);

            matrix[row, col] = EmptyCellSymbol;
        }

        private void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
