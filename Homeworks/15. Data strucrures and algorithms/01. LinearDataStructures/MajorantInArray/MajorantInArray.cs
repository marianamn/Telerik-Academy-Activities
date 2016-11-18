// The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
// 
// Write a program to find the majorant of given array(if exists).
// Example:
// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3

namespace MajorantInArray
{
    using System;
    using System.Linq;

    public class MajorantInArray
    {
        public static void Main()
        {
            int[] numbers = ReadNumbersFromConsole();
            int? majorityElement = FindMajorantElement(numbers);
            
            if (majorityElement != null)
            {
                Console.WriteLine(majorityElement); 
            }
            else
            {
                Console.WriteLine("Majority element does not exist!");
            }
        }

        private static int? FindMajorantElement(int[] numbers)
        {
            int? majorityElement = null;
            int stack = 0;

            foreach (int number in numbers)
            {
                if (stack == 0)
                {
                    majorityElement = number;
                }

                stack += (number == majorityElement) ? 1 : -1;
            }

            int count = numbers.Count(n => n == majorityElement);

            if (!(count > (numbers.Length / 2)))
            {
                majorityElement = null;
            }

            return majorityElement;
        }

        private static int[] ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter number sequence, separated by comma and space:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            return array;
        }
    }
}
