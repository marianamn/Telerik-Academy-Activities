/*Problem 18.* Trailing Zeroes in N!
• Write a program that calculates with how many zeroes the factorial of a given number  n  has at its end.
• Your program should work well for very big numbers, e.g.  n=100000 .

Examples:
n         trailing zeroes of n!     explaination
10        2                         3628800 
20        4                         2432902008176640000 
100000    24999                     think why               */

using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        long countZeros = 0;

        for (int power5 = 5; power5 <= n; power5 *= 5)
        {
            countZeros += n / power5;
        }

        Console.WriteLine(countZeros);
    }
}

// slower way

//using System;
//using System.Numerics;
//
//class TrailingZeroesInNFactorial
//{
//    static void Main()
//    {
//        uint n = uint.Parse(Console.ReadLine());
//
//        BigInteger nFactorial = 1;
//        BigInteger countZeros = 0;
//
//
//        while (n > 0)
//        {
//            nFactorial *= n;
//            n--;
//        }
//        Console.WriteLine(nFactorial);
//
//        for (int i = 0; i < nFactorial; i++)
//        {
//            bool del = (nFactorial % 10) == 0;
//        
//            if (del)
//            {
//                countZeros++;
//                nFactorial = nFactorial / 10;
//            }
//            else
//            {
//                break;
//            }
//        }
//
//        // for the third example n=100000 you shoul wait couple of minutes to see the result in the console,
//        //because n! is too big number
//
//        Console.WriteLine(countZeros);
//    }
//}