/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
• Write a program that, for a given two integer numbers  n  and  x , calculates 
  the sum  S = 1 + 1!/x + 2!/x2 + … + n!/x^n .
• Use only one loop. Print the result with  5  digits after the decimal point.

Examples:
n    x     S
3    2     2.75000 
4    3     2.07407 
5   -4     0.75781   */

using System;

class CalculateOnePlusOneFactorielX
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        int factorial = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            double product = FindProduct(x, i);
            sum += factorial / product;
        }

        Console.WriteLine("{0:0.00000}",sum);
    }

    private static double FindProduct(double number, int count)
    {
        double product = 1;

        for (int i = 0; i < count; i++)
        {
            product *= number;
        }

        return product;
    }
}