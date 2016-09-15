using System;

namespace _01.Assertion
{
    public class Startup
    {
        public static void Main()
        {
            // Sort an array with with more than one elements, should not throw assertion error:
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSortAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Sort an array with zero and 1 element should throw assertion error:
            SelectionSortAlgorithm.SelectionSort(new int[0]);
            SelectionSortAlgorithm.SelectionSort(new int[1]);

            // Search an elemenet in array with more than one elements, should not throw assertion error.
            // Method returns eather element index or -1 if element not found
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 1000));

            // Search an elemenet in array should throw assertion error:
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(new int[0], -1000));
        }
    }
}
