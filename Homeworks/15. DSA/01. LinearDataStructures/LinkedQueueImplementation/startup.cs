namespace LinkedQueueImplementation
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var q = new LinkedQueue<int>();

            q.Enqueue(5);
            q.Enqueue(12);
            q.Enqueue(602);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }
    }
}