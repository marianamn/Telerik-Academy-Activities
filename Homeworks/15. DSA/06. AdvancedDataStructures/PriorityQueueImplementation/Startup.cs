// Implement a class PriorityQueue<T> based on the data structure "binary heap".

using System;
namespace PriorityQueueImplementation
{
    public class Program
    {
        public static void Main()
        {
            PriorityQueue<int> numbers = new PriorityQueue<int>();

            Console.WriteLine("Creating Priority Queue: ");
            numbers.Enqueue(1);
            Console.WriteLine("Added: {0}", 1);
            numbers.Enqueue(2);
            Console.WriteLine("Added: {0}", 2);
            numbers.Enqueue(3);
            Console.WriteLine("Added: {0}", 3);
            numbers.Enqueue(4);
            Console.WriteLine("Added: {0}", 4);
            numbers.Enqueue(5);
            Console.WriteLine("Added: {0}", 5);

            Console.WriteLine("Priority Queue: {0}", numbers.ToString());

            Console.WriteLine("Removed element: {0}", numbers.Dequeue());
            Console.WriteLine("Priority Queue: {0}", numbers.ToString());

            Console.WriteLine("Peeked element: {0}", numbers.Peek());

            numbers.Enqueue(6);
            Console.WriteLine("Added: {0}", 6);
            numbers.Enqueue(7);
            Console.WriteLine("Added: {0}", 7);
            Console.WriteLine("Resized Priority Queue: {0}", numbers.ToString());
        }
    }
}
