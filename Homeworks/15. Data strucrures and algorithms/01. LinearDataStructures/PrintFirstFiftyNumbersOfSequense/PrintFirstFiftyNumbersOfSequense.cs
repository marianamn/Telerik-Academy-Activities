// We are given the following sequence:
// 
// S1 = N;
// S2 = S1 + 1;
// S3 = 2* S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2* S2 + 1;
// S7 = S2 + 2;
// ...
// Using the Queue<T> class write a program to print its first 50 members for given N.
// Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace PrintFirstFiftyNumbersOfSequense
{
    using System;
    using System.Collections.Generic;

    public class PrintFirstFiftyNumbersOfSequense
    {
        private const int QueueLength = 50;

        public static void Main()
        {
            Console.WriteLine("Enter poditive number N:");
            int n = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);

            Console.WriteLine("First fifty numbers of sequence:");
            for (int i = 0; i < QueueLength; i++)
            {
                int currentNumber = sequence.Dequeue();

                if (i < (QueueLength - 1))
                {
                    Console.Write(currentNumber + ", ");
                }
                else
                {
                    Console.Write(currentNumber);
                }

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue((2 * currentNumber) + 1);
                sequence.Enqueue(currentNumber + 2);
            }

            Console.WriteLine();
        }
    }
}
