// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
// 
// Examples:
//          1 1
// n= 2->   1 2
//          2 1
//          2 2
// 
//          1 1 1
//          1 1 2
//          1 1 3
//          1 2 1
// n= 3->  ...
//          3 2 3
//          3 3 1
//          3 3 2
//          3 3 3

namespace SimulateNNestedLoops
{
    using System;
    
    public class SimulateNNestedLoops
    {
        public static void Main()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            NestedLoops(0, numbers);
        }

        private static void NestedLoops(int index, int[] numbers)
        {
            if (index >= numbers.Length)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 1; i <= numbers.Length; i++)
                {
                    numbers[index] = i;
                    NestedLoops(index + 1, numbers);
                }
            }
        }
    }
}
