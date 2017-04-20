using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Sorters
{
    public class QuickSort
    {
        public static IList<T> Sort<T>(IList<T> items) where T : IComparable<T>
        {
            if (items.Count <= 1)
            {
                return items;
            }

            var pivotIndex = items.Count / 2;
            var pivot = items[pivotIndex];
            items.RemoveAt(pivotIndex);

            var left = new List<T>();
            var right = new List<T>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(pivot) <= 0)
                {
                    left.Add(items[i]);
                }
                else
                {
                    right.Add(items[i]);
                }
            }

            var result = new List<T>();
            result.AddRange(Sort(left));
            result.Add(pivot);
            result.AddRange(Sort(right));

            return result;
        }
    }
}
