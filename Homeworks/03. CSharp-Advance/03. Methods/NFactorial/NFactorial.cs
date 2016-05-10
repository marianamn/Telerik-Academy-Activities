using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger[] array = new BigInteger[101];

        array = NFactorialMethod(array);
        if(n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
        for (int i = 1; i < array.Length; i++)
        {
            if (i == n)
            {
                Console.WriteLine(array[i]);
                break;
            }
        }
        }
    }

    static BigInteger[] NFactorialMethod(BigInteger[] array)
    {
        BigInteger product = 1;

        for (int i = 1; i < array.Length; i++)
        {
            product *= i;
            array[i] = product;
        }

        return array;
    }
}
