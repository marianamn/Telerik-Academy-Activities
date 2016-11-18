// Write a program that removes from given sequence all negative numbers.

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class RemoveNegativeNumbers
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            LinkedList<int> numbers = ReadNumbersFromConsole();

            var node = numbers.First;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value < 0)
                {
                    numbers.Remove(node);
                }   

                node = next;
            }

            Console.WriteLine("Positive numbers list: { " + string.Join(", ", numbers) + " }");
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
