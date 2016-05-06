using System;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] array = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine(Minimum(array));
        Console.WriteLine(Maximum(array));
        Console.WriteLine("{0:F2}", Average(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Product(array));
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

