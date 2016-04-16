/* Problem 6. Calculate N! / K!
• Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
• Use only one loop.

Examples:
n    k    n!/k!
5    2   60 
6    5   6 
8    3   6720   */


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger productN = 1;
        BigInteger productK = 1;
        BigInteger result = 1;

        while (n>0)
        {
            productN *= n;
            n--;

            if (k>0)
            {
                productK *= k;
                k--;
            }
            else
            {
                continue;
            }
        }

        result = productN / productK;

        Console.WriteLine(result);
    }
}