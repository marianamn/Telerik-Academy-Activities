// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n.
// Example:
// n= 3 → { 1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}

namespace AllPermutationsForN
{
    using System;

    public class AllPermutationsForN
    {
        public static void Main()
        {
            Console.WriteLine("Please enter number n:");
            int n = int.Parse(Console.ReadLine());

            int index = 0;
            int[] arrayOfNumbers = new int[n];
            bool[] isUsed = new bool[n];

            FindPermutations(index, n, arrayOfNumbers, isUsed);
        }

        private static void FindPermutations(int index, int n, int[] arrayOfNumbers, bool[] isUsed)
        {
            if (index == n)
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", arrayOfNumbers));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (isUsed[i])
                {
                    continue;
                }

                arrayOfNumbers[index] = i + 1;
                isUsed[i] = true;
                FindPermutations(index + 1, n, arrayOfNumbers, isUsed);
                isUsed[i] = false;
            }
        }
    }
}