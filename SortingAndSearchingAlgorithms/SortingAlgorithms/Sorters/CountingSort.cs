using System;
using System.Collections.Generic;

namespace SortingAndSearchingAlgorithms.Sorters
{
    public class CountingSort
    {
        public static List<T> Sort<T>(List<T> items, Func<T, int> sortBy) where T : IComparable<T>
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (int i = 0; i < items.Count; i++)
            {
                if (sortBy(items[i]) > max)
                {
                    max = sortBy(items[i]);
                }

                if (sortBy(items[i]) < min)
                {
                    min = sortBy(items[i]);
                }
            }

            var groups = new List<T>[max - min + 1];

            for (int i = 0; i < items.Count; i++)
            {
                if (groups[sortBy(items[i]) - min] == null)
                {
                    groups[sortBy(items[i]) - min] = new List<T>();
                }

                groups[sortBy(items[i]) - min].Add(items[i]);
            }

            var result = new List<T>();
            foreach (var group in groups)
            {
                if (group != null)
                {
                    result.AddRange(group);
                }
            }

            return result;
        }
    }
}
