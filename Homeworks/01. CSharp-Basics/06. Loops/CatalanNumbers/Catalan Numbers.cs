/*Problem 8. Catalan Numbers
• In combinatorics, the Catalan numbers are calculated by the following formula: 
  Cn = (2n)!/((n+1)!n!)
• Write a program to calculate the  n-th  Catalan number by given  n  (0 ≤ n ≤ 100). 

Examples:
n      Catalan(n)
0      1 
5      42 
10     16796 
15     9694845    */


using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int nProduct2 = n * 2;
        int nPlus1 = n + 1;

        BigInteger nFactorial = 1;
        BigInteger n2Factorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger result = 1;

        while (n > 0)
        {
            nFactorial *= n;
            n--;

            while (nProduct2 > 0)
            {
                n2Factorial *= nProduct2;
                nProduct2--;

                while (nPlus1 > 0)
                {
                    nPlusOneFactorial *= nPlus1;
                    nPlus1--;
                }
            }
        }

        result = n2Factorial / (nPlusOneFactorial * nFactorial);
        Console.WriteLine(result);
    }
}

//using System;
//using System.Numerics;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter number n: ");
//        int n = int.Parse(Console.ReadLine());
//        bool inRange = (0 <= n && n <= 100);
//        if (!inRange)
//        {
//            Console.WriteLine("Number you've entered not in range!");
//        }
//
//        int nProduct2 = n * 2;
//        int nPlus1 = n + 1;
//
//        BigInteger nFactorial = 1;
//        BigInteger n2Factorial = 1;
//        BigInteger nPlusOneFactorial = 1;
//        BigInteger result = 1;
//
//        while (n > 0)
//        {
//            nFactorial *= n;
//            n--;
//
//            while (nProduct2 > 0)
//            {
//                n2Factorial *= nProduct2;
//                nProduct2--;
//
//                while (nPlus1 > 0)
//                {
//                    nPlusOneFactorial *= nPlus1;
//                    nPlus1--;
//                }
//            }
//        }
//
//        result = n2Factorial / (nPlusOneFactorial * nFactorial);
//
//        if (inRange)
//        {
//            Console.WriteLine(result);
//        }
//        else
//        {
//            Console.WriteLine();
//        }
//
//    }
//}

