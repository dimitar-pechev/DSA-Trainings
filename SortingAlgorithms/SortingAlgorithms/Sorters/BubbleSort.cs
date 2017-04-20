using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Sorters
{
    public class BubbleSort
    {
        public static void Sort<T>(IList<T> items) where T : IComparable<T>
        {
            if (items.Count <= 1)
            {
                return;
            }

            var isDone = false;
            while (!isDone)
            {
                isDone = true;
                for (int i = 0; i < items.Count - 1; i++)
                {
                    if (items[i].CompareTo(items[i + 1]) > 0)
                    {
                        var temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        isDone = false;
                    }
                }
            }
        }
    }
}
