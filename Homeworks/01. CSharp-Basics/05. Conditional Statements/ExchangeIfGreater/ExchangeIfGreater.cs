/*Problem 1. Exchange If Greater
• Write an if-statement that takes two double variables a and b and exchanges their values if the first one 
  is greater than the second one. As a result print the values a and b, separated by a space.

Examples:
a      b     result
5      2     2 5 
3      4     3 4 
5.5    4.5   4.5 5.5  */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double tempB = a;
            a = b;

            Console.WriteLine("{0} {1}", a, tempB);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}