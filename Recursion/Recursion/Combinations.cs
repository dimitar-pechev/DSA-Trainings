using System;
using System.Linq;

namespace Recursion
{
    public class Combinations
    {
        public void GenerateWithRepetions(int n, string result = "")
        {
            if (!string.IsNullOrEmpty(result) && result.Split(' ').Where(x => x != string.Empty).ToArray().Length == n)
            {
                Console.WriteLine(result);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                GenerateWithRepetions(n, $"{result}{i} ");
            }
        }

        public void GenerateArrayWithRepetions(int n, int[] array, int startIndex = 0)
        {
            if (startIndex == n)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = startIndex; i < n; i++)
            {
                array[startIndex] = i + 1;
                GenerateArrayWithRepetions(n, array, startIndex + 1);
            }
        }

        public void GenerateCombinationOfKElements(int n, int k, string result = "")
        {
            if (!string.IsNullOrEmpty(result) && result.Split(' ').Where(x => x != string.Empty).ToArray().Length == k)
            {
                Console.WriteLine(result);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                GenerateCombinationOfKElements(n, k, $"{result}{i} ");
            }
        }

        public void GenerateCombinationOfKElementsWithoutDuplicates(int n, int k, string result = "")
        {
            if (!string.IsNullOrEmpty(result) && result.Split(' ').Where(x => x != string.Empty).ToArray().Length == k)
            {
                Console.WriteLine(result);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (result.Split(' ').ToList().Contains(i.ToString()))
                {
                    continue;
                }

                GenerateCombinationOfKElementsWithoutDuplicates(n, k, $"{result}{i} ");
            }
        }
    }
}
