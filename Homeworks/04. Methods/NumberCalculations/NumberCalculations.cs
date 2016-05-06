/*Problem 15.* Number calculations
• Modify your last program and try to make it work for any number type, not just integer 
  (e.g. decimal, float, byte, etc.)
• Use generic method (read in Internet about generic methods in C#). */

using System;
using System.Collections.Generic;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        int[] arrayOfInts = {2, 5, 10, 20, -5, 7, -1};
        double[] arrayOfDoubles = {2.2, 5.5, 10.12, 20.454, -5.34, -1.542524}; 
        float[] arrayOfFloats = {2.2f, 5.5f, 10.12f, 20.454f, -5.34f, -1.542524f};

        Console.WriteLine("Array of integer numbers: {2, 5, 10, 20, -5, 7, -1}");
        Console.WriteLine("Min={0} \nMax={1} \nAvrg={2} \nSum={3} \nProduct={4}",
                          Minimum(arrayOfInts), Maximum(arrayOfInts),Average(arrayOfInts),Sum(arrayOfInts),Product(arrayOfInts));

        Console.WriteLine();
        Console.WriteLine("Array of double numbers: {2.2, 5.5, 10.12, 20.454, -5.34, -1.542524}");
        Console.WriteLine("Min={0} \nMax={1} \nAvrg={2} \nSum={3} \nProduct={4}",
                          Minimum(arrayOfDoubles), Maximum(arrayOfDoubles), Average(arrayOfDoubles), Sum(arrayOfDoubles), Product(arrayOfDoubles));

        Console.WriteLine();
        Console.WriteLine("Array of float numbers: {2.2f, 5.5f, 10.12f, 20.454f, -5.34f, -1.542524f}");
        Console.WriteLine("Min={0} \nMax={1} \nAvrg={2} \nSum={3} \nProduct={4}",
                          Minimum(arrayOfFloats), Maximum(arrayOfFloats), Average(arrayOfFloats), Sum(arrayOfFloats), Product(arrayOfFloats));

    }


    static T Minimum<T> (params T[] array)
    {
        return array.Min();
    }

    static T Maximum<T>(params T[] array)
    {

        return array.Max();
    }

    static double Average<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum / (double)array.Length;

    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }

    static T Product<T>(params T[] array)
    {
        dynamic result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result = result * array[i];
        }
        return result;
    }
}

