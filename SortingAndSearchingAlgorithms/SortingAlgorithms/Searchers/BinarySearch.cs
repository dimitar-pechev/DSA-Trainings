using System;
using System.Collections.Generic;

namespace SortingAndSearchingAlgorithms.Searchers
{
    public class BinarySearch
    {
        public static int GetIndex<T>(List<T> items, T target) where T : IComparable<T>
        {
            var index = items.Count / 2;
            var start = 0;
            var end = items.Count - 1;

            while (start <= end)
            {
                if (items[index].CompareTo(target) == 0)
                {
                    return index;
                }
                else if (items[index].CompareTo(target) == 1)
                {
                    end = index - 1;
                }
                else
                {
                    start = index + 1;
                }

                index = (end - start) / 2 + start;
            }

            return -1;
        }
    }
}
