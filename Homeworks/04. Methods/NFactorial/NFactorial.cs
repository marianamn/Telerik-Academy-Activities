/*Problem 10. N Factorial
• Write a program to calculate  n!  for each  n  in the range [ 1..100 ].

Hint: Implement first a method that multiplies a number represented as array of digits 
by given integer number.   */

using System;
using System.Numerics;
class NFactorial
{
    static void Main()
    {
        BigInteger[] array = new BigInteger[101];

        array = NFactorialMethod(array);
        for (int i = 1; i < array.Length; i++)
        {
            Console.WriteLine("{0}!={1}",i, array[i]);
        }
        Console.WriteLine();
    }

    static BigInteger[] NFactorialMethod(BigInteger[] array)
    {
        BigInteger product = 1;
        for (int i = 1; i <array.Length; i++)
        {
            product *= i;
            array [i] = product;
        }
        return array;
    }
}
