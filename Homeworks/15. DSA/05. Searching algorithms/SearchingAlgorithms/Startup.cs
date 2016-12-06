using System;

namespace SearchingAlgorithms
{
    public class Startup
    {
        public static void Main()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 }); ;
            Console.WriteLine("Initial collection:");
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("Linear search 101:");
            Console.WriteLine(collection.LinearSearch(101));
            Console.WriteLine();

            Console.WriteLine("Binary search 101:");
            Console.WriteLine(collection.BinarySearch(101));
            Console.WriteLine();

            Console.WriteLine("Shuffle:");
            collection.Shuffle();
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("Shuffle again:");
            collection.Shuffle();
            collection.PrintAllItemsOnConsole();
        }
    }
}
