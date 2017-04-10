using System;
using System.Collections.Generic;
using System.Linq;

namespace Dividers
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = (new int[n]).Select(x => x = int.Parse(Console.ReadLine())).ToArray();

            var resultNumbers = new List<int>();
            GetPermutations(numbers, new bool[numbers.Length], resultNumbers, n);

            var resultNumber = int.MaxValue;
            var smallestNumberOfDevisors = int.MaxValue;

            for (int i = 0; i < resultNumbers.Count; i++)
            {
                var divisors = 0;
                for (int j = 1; j < resultNumbers[i]; j++)
                {
                    if (resultNumbers[i] % j == 0)
                    {
                        divisors++;
                    }
                }

                if (divisors <= smallestNumberOfDevisors)
                {
                    if (divisors == smallestNumberOfDevisors && resultNumber < resultNumbers[i])
                    {
                        continue;
                    }

                    smallestNumberOfDevisors = divisors;
                    resultNumber = resultNumbers[i];
                }
            }

            Console.WriteLine(resultNumber);
        }

        public static void GetPermutations(int[] numbers, bool[] canPlaceNumber, List<int> resultNumbers, int numberSize, string result = "")
        {
            if (result.Length == numberSize)
            {
                var parsedResult = int.Parse(result);

                if (resultNumbers.Contains(parsedResult))
                {
                    return;
                }

                resultNumbers.Add(parsedResult);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {  
                if (!canPlaceNumber[i])
                {
                    canPlaceNumber[i] = true;
                    GetPermutations(numbers, canPlaceNumber, resultNumbers, numberSize, result + numbers[i]);
                    canPlaceNumber[i] = false;
                }              
            }
        }
    }
}
