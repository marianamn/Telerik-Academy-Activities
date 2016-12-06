// Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.

namespace SortNumbersInList
{
    using System;
    using System.Collections.Generic;

    public class SortNumbersInList
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            List<int> numbers = ReadNumbersFromConsole();
            Console.WriteLine("Initial numbers in List:");
            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");

            numbers.Sort();
            Console.WriteLine("Sorted numbers in List:");
            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
        }

        private static List<int> ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter numbers:");

            List<int> numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != EndOfInput)
                {
                    numbers.Add(int.Parse(input));
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