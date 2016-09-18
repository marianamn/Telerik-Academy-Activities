using System;
using System.Diagnostics;

namespace _04.CompareSortAlgorithms
{
    public class Startup
    {
        private const int RepeatCount = 1000000;
        private const string IntMessage = "Measure Sort algorithms with Int values";
        private const string DoubleMessage = "Measure Sort algorithms with Double values";
        private const string StringMessage = "Measure Sort algorithms with String values";
        private const string RandomIntMessage = "Measure Sort algorithms with Random Int values";
        private const string SortedAscendingIntMessage = "Measure Sort algorithms with Ascending Int values";
        private const string SortedDescendingIntMessage = "Measure Sort algorithms with Descending Int values";

        public static void Main()
        {
            MeasuringSortingAlgorithmsWithInt();
            MeasuringSortingAlgorithmsWithIntDouble();
            MeasuringSortingAlgorithmsWithIntString();
            MeasuringSortingAlgorithmsWithRandomValues();
            MeasuringSortingAlgorithmsWithSortedAscendingValues();
            MeasuringSortingAlgorithmsWithSortedDescendingValues();
        }

        private static void MeasuringSortingAlgorithmsWithInt()
        {
            int[] numbers = { 4, 5, 1, 100, 0, -5 };

            MeasureOperations(numbers, IntMessage);
        }

        private static void MeasuringSortingAlgorithmsWithIntDouble()
        {
            double[] numbers = { 4.5, 5, 0.25, 100.23, -5.2, 6.2 };

            MeasureOperations(numbers, DoubleMessage);
        }

        private static void MeasuringSortingAlgorithmsWithIntString()
        {
            string[] words = { "abc", "ddd", "Htg", "skj" };

            MeasureOperations(words, StringMessage);
        }

        private static void MeasuringSortingAlgorithmsWithRandomValues()
        {
            int[] numbers = new int[6];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }

            MeasureOperations(numbers, RandomIntMessage);
        }

        private static void MeasuringSortingAlgorithmsWithSortedAscendingValues()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            MeasureOperations(numbers, SortedAscendingIntMessage);
        }

        private static void MeasuringSortingAlgorithmsWithSortedDescendingValues()
        {
            int[] numbers = { 5, 4, 3, 2, 1, 0 };

            MeasureOperations(numbers, SortedDescendingIntMessage);
        }

        private static void MeasureOperations<T>(T[] numbers, string message)
            where T : IComparable
        {
            Console.WriteLine("======={0}=======", message);
            Console.WriteLine();

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SortAlgorithms.SelectionSort(numbers);
            }

            stopWatch.Stop();
            Console.WriteLine("Selection Sort execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SortAlgorithms.Quicksort(numbers, 0, numbers.Length - 1);
            }

            stopWatch.Stop();
            Console.WriteLine("Quick Sort execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SortAlgorithms.InsertionSort(numbers);
            }

            stopWatch.Stop();
            Console.WriteLine("Insertion Sort execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            Console.WriteLine();
        }
    }
}
