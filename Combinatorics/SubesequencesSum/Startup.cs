using System;
using System.Linq;

namespace SubesequencesSum
{
    public class Startup
    {
        public static void Main()
        {
            var testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var n = input[0];
                var k = input[1];

                var sequenceSum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Sum();

                var subsequenceSum = CalculateBinom(n - 1, k) * sequenceSum;

                Console.WriteLine(subsequenceSum);
            }
        }

        public static long CalculateBinom(int n, int k)
        {
            long result = 1;
            for (int i = n; i >= (n - k + 1); i--)
            {
                result *= i;
            }

            long denominator = 1;
            for (int i = k; i >= 1; i--)
            {
                denominator *= i;
            }

            result /= denominator;

            return result;
        }
    }
}
