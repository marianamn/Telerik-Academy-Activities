using System;

namespace SortingAlgorithms
{
    public class Startup
    {
        public static void Main()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("All items before sorting:");
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("SelectionSorter result:");
            collection.Sort(new SelectionSorter<int>());
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("Quicksorter result:");
            collection.Sort(new QuickSorter<int>());
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("MergeSorter result:");
            collection.Sort(new MergeSorter<int>());
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();
        }
    }
}
