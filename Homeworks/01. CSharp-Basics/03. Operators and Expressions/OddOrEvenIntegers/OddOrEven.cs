/*Problem 1. Odd or Even Integers
• Write an expression that checks if given integer is odd or even.
Examples:
 n       Odd?
 3       true 
 2       false 
-2       false 
-1       true 
 0       false */

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isNumberEven = number % 2 == 0;

        if (isNumberEven)
        {
            Console.WriteLine("even {0}", number);
        }
        else
        {
            Console.WriteLine("odd {0}", number);
        }
    }
}