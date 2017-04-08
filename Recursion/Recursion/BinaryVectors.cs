using System;

namespace Recursion
{
    public class BinaryVectors
    {
        public void GetVectors(int number, string result = "")
        {
            if (number == 0)
            {
                Console.WriteLine(result);
                return;
            }

            this.GetVectors(number - 1, result + 0);
            this.GetVectors(number - 1, result + 1);
        }
    }
}
