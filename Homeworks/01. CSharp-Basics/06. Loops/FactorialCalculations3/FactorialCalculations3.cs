/* Problem 7. Calculate N! / (K! * (N-K)!)
 • In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements (also known as the number of combinations) is calculated by the following formula: formula 
 For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
• Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100). 
  Try to use only two loops.

Examples:
n    k       n! / (k! * (n-k)!)
3    2       3 
4    2       6 
10   6       210 
52   5       2598960     */

using System;
using System.Numerics;

class FactorialCalculations3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nMinusK = n - k;

        BigInteger productN = 1;
        BigInteger productK = 1;
        BigInteger productNK = 1;
        BigInteger result = 1;

        while (n > 0)
        {
            productN *= n;
            n--;

            while (k > 0)
            {
                productK *= k;
                k--;
            }

            if (nMinusK > 0)
            {
                productNK *= nMinusK;
                nMinusK--;
            }
            else
            {
                continue;
            }
        }

        result = productN / (productK * productNK);
        Console.WriteLine(result);
    }
}

//using System;
//using System.Numerics;
//
//class FactorialCalculations3
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter number n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter number k: ");
//        int k = int.Parse(Console.ReadLine());
//        bool inRange = (1 < k && k < n && n < 100);
//        if (!inRange)
//        {
//            Console.WriteLine("Numbers you've entered not in range!");
//        }
//
//
//        int nMinusK = n - k;
//
//        BigInteger productN = 1;
//        BigInteger productK = 1;
//        BigInteger productNK = 1;
//        BigInteger result = 1;
//
//        while (n > 0)
//        {
//            productN *= n;
//            n--;
//            while (k > 0)
//            {
//                productK *= k;
//                k--;
//            }
//
//            if (nMinusK > 0)
//            {
//                productNK *= nMinusK;
//                nMinusK--;
//            }
//            else
//            {
//                continue;
//            }
//        }
//
//        result = productN / (productK * productNK);
//
//        if (inRange)
//        {
//            Console.WriteLine(result);
//        }
//        else
//        {
//            Console.WriteLine();
//        }
//    }
//}