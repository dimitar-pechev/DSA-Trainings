using System;
using System.Numerics;

namespace Recursion
{
    public class Startup
    {
        public static void Main()
        {
            //var factorialGen = new RevursiveFactorial();
            //var number = BigInteger.Parse(Console.ReadLine());
            //Console.WriteLine(factorialGen.Factorial(number));

            //var binaryVectorsGenerator = new BinaryVectors();
            //var digitsCount = int.Parse(Console.ReadLine());
            //binaryVectorsGenerator.GetVectors(digitsCount);

            //var combinationsGen = new Combinations();
            //var n = 5;
            //var arr = new int[n];
            //combinationsGen.GenerateArrayWithRepetions(n, arr);            

            //var n = 3;
            //var k = 3;
            //combinationsGen.GenerateCombinationOfKElementsWithoutDuplicates(n, k);

            //var matrix = new char[,]
            //    {
            //        { '.', '.', '.', 'x', '.', '.', '.' },
            //        { 'x', 'x', '.', 'x', '.', 'x', '.' },
            //        { '.', '.', '.', 'x', 'x', 'x', '.' },
            //        { '.', '.', '.', '.', '.', '.', '.' },
            //        { '.', 'x', '.', 'x', 'x', 'x', '.' },
            //        { '.', 'x', '.', '.', '.', 'x', '.' },
            //        { '.', 'x', '.', '.', '.', 'x', '.' },
            //        { '.', 'x', '.', '.', '.', 'x', '.' },
            //        { '.', 'x', 'x', 'x', 'x', 'x', '.' },
            //        { '.', '.', '.', '.', '.', '.', 'E' },
            //    };

            //var matrixPathFinder = new MatrixPathFinder();
            //matrixPathFinder.PrintPathBetweenTwoCells(matrix);

            //var n = 5;
            //var queens = new EightQueensPuzzle();
            //queens.PrintPossiblePositions(n, new bool[n, n]);

            var sudokuSolver = new SudokuSolver();

            var sudoku = new int[,]
            {
                { 2, 1, 7, 0, 0, 0, 0, 0, 8 },
                { 0, 3, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 4, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 7, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 5, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 6, 0, 0, 0 },
                { 0, 7, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 9 },
            };
            sudokuSolver.Solve(sudoku);
        }
    }
}
