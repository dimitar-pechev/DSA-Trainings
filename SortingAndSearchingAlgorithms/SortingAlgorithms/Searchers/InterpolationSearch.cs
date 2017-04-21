using System.Collections.Generic;

namespace SortingAndSearchingAlgorithms.Searchers
{
    public class InterpolationSearch
    {
        public static int GetIndex(List<int> numbers, int target)
        {
            var start = 0;
            var end = numbers.Count - 1;

            while (numbers[start] <= target && target <= numbers[end])
            {
                var index = start + ((target - numbers[start]) * (end - start)) / (numbers[end] - numbers[start]);

                if (numbers[index] < target)
                {
                    start = index + 1;
                }
                else if (numbers[index] > target)
                {
                    end = index - 1;
                }
                else
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
