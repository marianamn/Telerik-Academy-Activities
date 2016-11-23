// Write a recursive program for generating and printing all ordered k-element subsets from n-element set(variations Vkn).
// Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)

namespace AllOrderedKsubsetsFromNElements
{
    using System;
    using System.Linq;

    public class AllOrderedKsubsetsFromNElements
    {
        public static void Main()
        {
            Console.WriteLine("Please enter number n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number k:");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter string subsets from n-element, separated by comma:");
            string input = Console.ReadLine();
            string[] set = new string[n];
            set = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            if (!(0 < k && k <= n) || set.Length != n)
            {
                throw new Exception("Invalid input!");
            }

            int index = 0;
            int[] variation = new int[k];
            FindVariations(index, n, k, variation, set);
        }

        private static void FindVariations(int index, int n, int k, int[] variation, string[] set)
        {
            if (index == k)
            {
                Console.WriteLine("({0})", string.Join(", ", variation.Select(x => set[x])));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variation[index] = i;
                FindVariations(index + 1, n, k, variation, set);
            }
        }
    }
}