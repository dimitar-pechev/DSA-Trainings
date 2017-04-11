using System;
using System.Collections.Generic;
using System.Linq;

namespace ZigZagLines
{
    public class Startup
    {
        private static int counter;

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = input[0];
            var k = input[1];

            var variations = new List<int[]>();
            GetVariations(n, k, new int[k], new bool[n]);

            Console.WriteLine(counter);
        }

        public static void GetVariations(int n, int k, int[] currentVariation, bool[] canPlaceNumber, int index = 0)
        {
            if (index == k)
            {
                counter++;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!canPlaceNumber[i])
                {
                    var previous = index != 0 ? currentVariation[index - 1] : 0;

                    if (!IsValidNumber(index, i, previous))
                    {
                        continue;
                    }

                    canPlaceNumber[i] = true;
                    currentVariation[index] = i;
                    GetVariations(n, k, currentVariation, canPlaceNumber, index + 1);
                    canPlaceNumber[i] = false;
                }
            }
        }

        public static bool IsValidNumber(int i, int current, int previous)
        {
            if (i == 0)
            {
                return true;
            }
            else if (i % 2 == 0)
            {
                if (current > previous)
                {
                    return true;
                }
            }
            else
            {
                if (current < previous)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
