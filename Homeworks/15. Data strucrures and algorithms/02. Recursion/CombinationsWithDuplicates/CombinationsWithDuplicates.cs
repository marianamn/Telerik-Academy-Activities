// Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set.Example:
// n= 3, k= 2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)

namespace CombinationsWithDuplicates
{
    using System;

    public class CombsDuplicates
    {
        public class CombinationsWithDuplicates
        {
            public static void Main()
            {
                Console.WriteLine("Enter n:");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter k:");
                int k = int.Parse(Console.ReadLine());

                int[] arr = new int[k];
                GenerateCombinations(0, n, 1, arr);
            }

            private static void GenerateCombinations(int index, int end, int start, int[] arr)
            {
                if (index >= arr.Length)
                {
                    Console.WriteLine("(" + string.Join(", ", arr) + ")");
                }
                else
                {
                    for (int i = start; i <= end; i++)
                    {
                        arr[index] = i;
                        GenerateCombinations(index + 1, end, i, arr);
                    }
                }
            }
        }
    }
}
