using System;

namespace BinaryPasswords
{
    public class Startup
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();

            var symbolsCount = 0;
            var patternLength = pattern.Length;
            for (int i = 0; i < patternLength; i++)
            {
                if (pattern[i] == '*')
                {
                    symbolsCount++;
                }
            }

            var options = 1L;
            for (int i = 0; i < symbolsCount; i++)
            {
                options *= 2;
            }

            Console.WriteLine(options);
        }
    }
}
