using System;
using System.Numerics;

namespace Recursion
{
    public class RevursiveFactorial
    {
        public BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number < 0)
            {
                throw new InvalidOperationException("Cannot calculate factorial of a negative number!");
            }
            
            return this.Factorial(number - 1) * number;
        }
    }
}
