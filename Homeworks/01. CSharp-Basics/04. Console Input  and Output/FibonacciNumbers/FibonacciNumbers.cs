/*Problem 10. Fibonacci Numbers
• Write a program that reads a number  n  and prints on the console the first  n  members of 
the Fibonacci sequence (at a single line, separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .

Note: You may need to learn how to use loops.

Examples:
n           comments
1           0 
3           0 1 1 
10          0 1 1 2 3 5 8 13 21 34   */

using System;
class FibonacciNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        long first = 0;
        long second = 1;
        long sum = first + second;

        for (int i = 0; i < count; i++)
        {
            Console.Write(first);

            if (i < count-1)
            {
                Console.Write(", ");
            }

            first = second;
            second = sum;
            sum = first + second;
        }

        Console.WriteLine();
    }
}