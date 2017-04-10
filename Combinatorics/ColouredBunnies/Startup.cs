using System;
using System.Collections.Generic;

namespace ColouredBunnies
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var groups = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                var current = int.Parse(Console.ReadLine()) + 1;
                if (!groups.ContainsKey(current))
                {
                    groups.Add(current, 1);
                }
                else
                {
                    groups[current]++;
                }
            }

            var bunnies = 0d;
            foreach (var groupSize in groups.Keys)
            {
                if (groupSize > 0)
                {
                    bunnies += Math.Ceiling((double)groups[groupSize] / groupSize) * groupSize;
                }
            }

            Console.WriteLine(bunnies);
        }
    }
}
