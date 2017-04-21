using System;
using System.Collections.Generic;
using System.Threading;
using SortingAndSearchingAlgorithms.Sorters;
using SortingAndSearchingAlgorithms.Searchers;

namespace SortingAndSearchingAlgorithms
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = GenerateRange(1, 30);
            Shuffle(numbers);

            Console.WriteLine(string.Join(" ", numbers));
            var sortedList = MergeSort.Sort(numbers);
            Console.WriteLine(string.Join(" ", sortedList));

            Console.WriteLine(InterpolationSearch.GetIndex(sortedList, 25));
        }

        public static void Shuffle<T>(IList<T> items)
        {
            var random = new Random();

            for (int i = 0; i < items.Count - 1; i++)
            {
                var randomIndex = random.Next(i + 1, items.Count);
                var tempValue = items[i];
                items[i] = items[randomIndex];
                items[randomIndex] = tempValue;
            }
        }

        public static List<int> GenerateRange(int lowerBound, int upperBound)
        {
            var numbers = new List<int>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        public class Card : IComparable<Card>
        {
            public Card()
            {
                var random = new Random();
                this.Value = random.Next(2, 15);
                Thread.Sleep(20);
            }

            public int Value { get; set; }

            public int CompareTo(Card other)
            {
                if (this.Value < other.Value)
                {
                    return -1;
                }
                else if (this.Value > other.Value)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
