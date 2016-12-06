// We are given numbers N and M and the following operations:
// 
// N = N+1
// N = N+2
// N = N*2
// 
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
// 
// Hint: use a queue.
// Example: N = 5, M = 16
// Sequence: 5 → 7 → 8 → 16

namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortestSequenceOfOperations
    {
        public static void Main()
        {
            Console.WriteLine("Enter poditive number N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter poditive number M:");
            int m = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(m);
            var currentNumber = m;

            while (currentNumber > n)
            {
                if (currentNumber / 2 >= n)
                {
                    currentNumber /= 2;
                }
                else if (currentNumber - 2 >= n)
                {
                    currentNumber -= 2;
                }
                else if (currentNumber - 1 >= n)
                {
                    currentNumber--;
                }

                sequence.Enqueue(currentNumber);
            }
            
            var orderedSequence = sequence.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", orderedSequence));
        }
    }
}
