using System;
using System.Diagnostics;

namespace _01.Assertion
{
    public class SelectionSortAlgorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Cannot sort empty array!");
            Debug.Assert(arr.Length != 1, "Cannot sort an array with single element!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Cannot sort empty array!");
            Debug.Assert(arr.Length != 1, "Cannot sort an array with single element!");
            Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "Invalid endIndex value.");
            Debug.Assert(startIndex <= endIndex, "Start index must be less than end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(minElementIndex >= 0, "Invalid minElement index!");
            return minElementIndex;
        }

        private static void Swap<T>(ref T firstElement, ref T secondElement)
        {
            Debug.Assert(firstElement != null, "First swapping value cannot be null.");
            Debug.Assert(secondElement != null, "Second swapping cannot be null.");

            T oldFirstElement = firstElement;
            firstElement = secondElement;
            secondElement = oldFirstElement;
        }
    }
}
