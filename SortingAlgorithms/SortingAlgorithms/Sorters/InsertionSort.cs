using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Sorters
{
    public class InsertionSort
    {
        public static void Sort<T>(IList<T> items) where T : IComparable<T>
        {
            for (int i = 1; i < items.Count; i++)
            {
                var j = i;
                while (j > 0 && items[j].CompareTo(items[j - 1]) <= 0)
                {
                    Swap(items, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap<T>(IList<T> items, int firstIndex, int secondIndex)
        {
            var tempValue = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempValue;
        }
    }
}
