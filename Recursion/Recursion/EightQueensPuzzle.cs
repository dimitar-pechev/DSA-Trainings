using System;

namespace Recursion
{
    public class EightQueensPuzzle
    {
        public void PrintPossiblePositions(int n, bool[,] board)
        {
            if (n == 0)
            {
                PrintBoard(board);
            }
            
            var row = n - 1;

            if (row < 0)
            {
                return;
            }

            for (int col = 0; col < board.GetLength(1); col++)
            {
                var deltaX = new int[] { 1, 1, 1 };
                var deltaY = new int[] { 0, -1, 1 };

                var canPlaceQueen = true;

                for (int i = 0; canPlaceQueen && i < deltaX.Length; i++)
                {
                    var x = row;
                    var y = col;

                    while (x >= 0 && y >= 0 && x < board.GetLength(0) && y < board.GetLength(1))
                    {
                        if (board[x, y])
                        {
                            canPlaceQueen = false;
                            break;
                        }

                        x += deltaX[i];
                        y += deltaY[i];
                    }
                }

                if (canPlaceQueen)
                {
                    board[row, col] = true;
                    PrintPossiblePositions(n - 1, board);
                    board[row, col] = false;
                }
            }            
        }

        private void PrintBoard(bool[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    var symbol = board[row, col] ? "Q" : ".";
                    Console.Write($"{symbol} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
