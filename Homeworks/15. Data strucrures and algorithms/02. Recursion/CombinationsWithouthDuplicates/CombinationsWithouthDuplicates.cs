// Modify the previous program to skip duplicates:
// n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)

namespace CombinationsWithouthDuplicates
{
    using System;

    public class CombinationsWithouthDuplicates
    {
        public static void Main()
        {
            Console.WriteLine("Enter n:");
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());

            int startNum = 1;
            int index = 1;

            int[] arr = new int[k];
            GenerateCombinations(arr, index, startNum, endNum);
        }

        private static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i + 1, endNum);
                }
            }
        }
    }
}