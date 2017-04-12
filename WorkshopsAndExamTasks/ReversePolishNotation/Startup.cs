using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversePolishNotation
{
    public class Startup
    {
        public static void Main()
        {
            var expression = Console.ReadLine().Split(' ').ToArray();

            var stack = new Stack<int>();
            
            foreach (var element in expression)
            {
                int number;
                if (int.TryParse(element, out number))
                {
                    stack.Push(number);
                    continue;
                }

                var secondNumber = stack.Pop();
                var firstNumber = stack.Pop();

                stack.Push(CalcultateExpression(firstNumber, secondNumber, element));
            }

            Console.WriteLine(stack.Pop());
        }

        private static int CalcultateExpression(int firstNumber, int secondNumber, string item)
        {
            switch (item)
            {
                case "+": return firstNumber + secondNumber;
                case "-": return firstNumber - secondNumber;
                case "*": return firstNumber * secondNumber;
                case "/": return firstNumber / secondNumber;
                case "&": return firstNumber & secondNumber;
                case "^": return firstNumber ^ secondNumber;
                case "|": return firstNumber | secondNumber;
                default: throw new InvalidOperationException();
            }
        }
    }
}
