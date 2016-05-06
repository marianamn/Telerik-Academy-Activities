/*Problem 14. Integer calculations
• Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set 
  of integer numbers.
• Use variable number of arguments. */

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number sequence, separated by commas and space:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine("Min={0}", Minimum(array));
        Console.WriteLine("Max={0}", Maximum(array));
        Console.WriteLine("Avrg={0}", Average(array));
        Console.WriteLine("Sum={0}", Sum(array));
        Console.WriteLine("Product={0}", Product(array));
    }


    static int Minimum(int[] array)
    {
        int result = array.Min();
        return result;
    }

    static int Maximum(int[] array)
    {
        int result = array.Max();
        return result;
    }

    static double Average(int[] array)
    {
        double result = array.Average();
        return result;
    }

    static int Sum(int[] array)
    {
        int result = array.Sum();
        return result;
    }

    static int Product(int[] array)
    {
        int result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result = result * array[i];
        }
        return result;
    }
}
