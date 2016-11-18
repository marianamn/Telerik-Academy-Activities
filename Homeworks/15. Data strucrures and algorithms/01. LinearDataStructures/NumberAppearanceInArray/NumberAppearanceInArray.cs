// Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.
// 
// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2 → 2 times
// 3 → 4 times
// 4 → 3 times

namespace NumberAppearanceInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberAppearanceInArray
    {
        public static void Main()
        {
            int[] numbers = ReadNumbersFromConsole();
            var groupedNumbers = GroupByOccurrence(numbers);

            foreach (var item in groupedNumbers)
            {
                Console.WriteLine(item.Key + " --> " + item.Value + " times");
            }
        }

        private static IDictionary<T, int> GroupByOccurrence<T>(IEnumerable<T> numbers)
        {
            return numbers.GroupBy(num => num)
                          .OrderBy(x => x.Key)
                          .ToDictionary(group => group.Key, group => group.Count());
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
