// Write a program that removes from given sequence all numbers that occur odd number of times.
// 
// Example:
// { 4, 2, 2, 5, 2, 3, 2, 3, 5, 2} → {5, 3, 3, 5}

namespace ExtractOddNumbers
{
    using System;
    using System.Collections.Generic;

    public class ExtractOddNumbers
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            LinkedList<int> numbers = ReadNumbersFromConsole();

            var node = numbers.First;

            while (node != null)
            {
                var next = node.Next;

                if ((node.Value % 2) == 0)
                {
                    numbers.Remove(node);
                }
                    
                node = next;
            }

            Console.WriteLine("Extracted odd numbers: { " + string.Join(", ", numbers) + " }");
        }

        private static LinkedList<int> ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter numbers:");

            LinkedList<int> numbers = new LinkedList<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != EndOfInput)
                {
                    numbers.AddLast(int.Parse(input));
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
