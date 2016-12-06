// Write a program for generating and printing all subsets of k strings from given set of strings.
// Example: 
// s = {test, rock, fun}
// k = 2 
// → (test rock), (test fun), (rock fun)

namespace AllSubsetsOfKStringsFomGivenSet
{
    using System;
    using System.Linq;

    public class AllSubsetsOfKStringsFomGivenSet
    {
        public static void Main()
        {
            Console.WriteLine("Please enter string subsets, separated by comma:");
            string input = Console.ReadLine();

            string[] set = new string[input.Length];
            set = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Please enter number k:");
            int k = int.Parse(Console.ReadLine());
            var n = set.Length;

            if (!(0 < k && k <= n))
            {
                throw new Exception("Invalid input!");
            }

            int index = 0;
            int[] combination = new int[k];
            FindAllSubsetsOfStrings(index, n, k, combination, set);
        }

        private static void FindAllSubsetsOfStrings(int index, int n, int k, int[] combination, string[] set)
        {
            if (index == k)
            {
                Console.WriteLine("({0})", string.Join(" ", combination.Select(x => set[x])));
                return;
            }

            int value = (index == 0) ? 0 : combination[index - 1] + 1;

            for (int i = value; i < n; i++)
            {
                combination[index] = i;
                FindAllSubsetsOfStrings(index + 1, n, k, combination, set);
            }
        }
    }
}