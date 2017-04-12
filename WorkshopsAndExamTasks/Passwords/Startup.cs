using System;

namespace Passwords
{
    public class Startup
    {
        private static int counter;
        private static bool isDone;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var pattern = Console.ReadLine();
            var k = int.Parse(Console.ReadLine());

            var password = new int[n];

            GetKthPassword(password, pattern, n, k);
        }

        private static void GetKthPassword(int[] password, string pattern, int n, int k, int index = 0)
        {
            if (isDone)
            {
                return;
            }
            
            if (index == n)
            {
                counter++;

                if (k == counter)
                {
                    Console.WriteLine(string.Join("", password));
                    isDone = true;
                }

                return;
            }

            if (index == 0)
            {
                password[index] = 0;
                GetKthPassword(password, pattern, n, k, index + 1);

                for (int i = 1; i <= 9; i++)
                {
                    password[index] = i;
                    GetKthPassword(password, pattern, n, k, index + 1);
                }                
            }
            else
            {
                if (pattern[index - 1] == '=')
                {
                    password[index] = password[index - 1];
                    GetKthPassword(password, pattern, n, k, index + 1);
                }
                else if (pattern[index - 1] == '>')
                {
                    if (password[index - 1] == 0)
                    {
                        return;
                    }
                    
                    password[index] = 0;
                    GetKthPassword(password, pattern, n, k, index + 1);

                    for (int i = password[index - 1] + 1; i <= 9; i++)
                    {
                        password[index] = i;
                        GetKthPassword(password, pattern, n, k, index + 1);
                    }
                }
                else if (pattern[index - 1] == '<')
                {
                    if (password[index - 1] == 1)
                    {
                        return;
                    }

                    var end = password[index - 1] != 0 ? password[index - 1] - 1 : 9;

                    for (int i = 1; i <= end; i++)
                    {
                        password[index] = i;
                        GetKthPassword(password, pattern, n, k, index + 1);
                    }
                }
            }
        }
    }
}
