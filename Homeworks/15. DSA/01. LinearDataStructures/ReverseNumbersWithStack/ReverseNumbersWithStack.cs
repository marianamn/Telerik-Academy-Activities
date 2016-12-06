// Write a program that reads N integers from the console and reverses them using a stack.
// 
// Use the Stack<int> class.

namespace ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    public class ReverseNumbersWithStack
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            Stack<int> numbers = ReadNumbersFromConsole();

            Console.WriteLine("Reversed numbers:");
            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
        }

        private static Stack<int> ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter numbers:");

            Stack<int> numbers = new Stack<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != EndOfInput)
                {
                    numbers.Push(int.Parse(input));
                }
                else
                {
                    break;
                }
            }

            return numbers;
        }
    }
}
