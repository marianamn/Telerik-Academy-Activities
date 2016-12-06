// * Write a program to generate all permutations with repetitionsof given multi-set.
//  Example: the multi-set {1, 3, 5, 5} has the following 12 unique permutations:
//   { 1, 3, 5, 5 }  { 1, 5, 3, 5 }
//   { 1, 5, 5, 3 }  { 3, 1, 5, 5 }
//   { 3, 5, 1, 5 }  { 3, 5, 5, 1 }
//   { 5, 1, 3, 5 }  { 5, 1, 5, 3 }
//   { 5, 3, 1, 5 }  { 5, 3, 5, 1 }
//   { 5, 5, 1, 3 }  { 5, 5, 3, 1 }
// Ensure your program efficiently avoids duplicated permutations.
// Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.
// Hint: Permutations with repetition

namespace PermutWithRepeat
{
    using System;

    public class PermutWithRepeat
    {
        public static void Main()
        {
            var arr = new[] { 1, 3, 5, 5 };

            int startIndex = 0;
            Array.Sort(arr);
            PermuteRep(arr, startIndex, arr.Length);
        }

        private static void PermuteRep(int[] arr, int start, int n)
        {
            Print(arr);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];

                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        private static void Print<T>(T[] arr)
        {
            Console.WriteLine("{{{0}}}", string.Join(", ", arr));
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}