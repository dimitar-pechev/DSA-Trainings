using System;
using System.Collections.Generic;
using System.Numerics;

namespace ColouredBalls
{
    public class Startup
    {
        public static void Main()
        {
            var balls = Console.ReadLine();

            var symbolGroups = new Dictionary<char, int>();
            for (int i = 0; i < balls.Length; i++)
            {
                if (!symbolGroups.ContainsKey(balls[i]))
                {
                    symbolGroups[balls[i]] = 1;
                }
                else
                {
                    symbolGroups[balls[i]]++;
                }
            }

            var result = Factorial(balls.Length);
            foreach (var item in symbolGroups.Values)
            {
                result /= Factorial(item);
            }


            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
