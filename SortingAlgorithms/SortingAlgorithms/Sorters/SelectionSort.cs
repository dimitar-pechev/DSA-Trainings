using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Sorters
{
    public class SelectionSort
    {
        public static void Sort<T>(IList<T> items) where T : IComparable<T>
        {
            if (items.Count <= 1)
            {
                return;
            }

            for (int i = 0; i < items.Count - 1; i++)
            {
                var smallestIndex = i;
                for (int j = i + 1; j < items.Count; j++)
                {
                    if (items[i].CompareTo(items[j]) > 0 && items[j].CompareTo(items[smallestIndex]) < 0)
                    {
                        smallestIndex = j;
                    }
                }

                if (!items[i].Equals(items[smallestIndex]))
                {
                    var temp = items[i];
                    items[i] = items[smallestIndex];
                    items[smallestIndex] = temp;
                }
            }
        }
    }
}
