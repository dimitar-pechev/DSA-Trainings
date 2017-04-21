using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAndSearchingAlgorithms.Sorters
{
    public class MergeSort
    {
        public static List<T> Sort<T>(List<T> items) where  T : IComparable<T>
        {
            if (items.Count <= 1)
            {
                return items;
            }

            var middleIndex = items.Count / 2;

            var left = new List<T>();
            var right = new List<T>();

            left = items.Take(middleIndex).ToList();
            right = items.Skip(middleIndex).ToList();

            left = Sort(left);
            right = Sort(right);

            var result = Merge(left, right);

            return result;
        }

        private static List<T> Merge<T>(List<T> first, List<T> second) where T : IComparable<T>
        {
            var result = new List<T>();

            var i = first.Count;
            var j = second.Count;
            while (i > 0 || j > 0)
            {
                if (i > 0 && j > 0)
                {
                    if (first[first.Count - i].CompareTo(second[second.Count - j]) <= 0)
                    {
                        result.Add(first[first.Count - i]);
                        i--;
                    }
                    else
                    {
                        result.Add(second[second.Count - j]);
                        j--;
                    }
                }
                else if (i > 0)
                {
                    var remaining = first.Skip(first.Count - i);
                    result.AddRange(remaining);
                    break;
                }
                else
                {
                    var remaining = second.Skip(second.Count - j);
                    result.AddRange(remaining);
                    break;
                }
            }

            return result;
        }
    }
}
