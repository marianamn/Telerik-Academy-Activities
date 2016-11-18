// Implement the ADT stack as auto-resizable array.
// 
// Resize the capacity on demand (when no space is available to add / insert a new element).

namespace StackAsAutoResizableArray
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // InitialSize = 4
            var stack = new StackImplementation<int>();

            stack.Push(12);
            stack.Push(50);
            Console.WriteLine("Pop: " + stack.Pop());

            stack.Push(-115);
            stack.Push(65);
            stack.Push(22);
            Console.WriteLine("Peek: " + stack.Peek());

            stack.Push(512);
            stack.Push(602);
            stack.Push(16);
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
