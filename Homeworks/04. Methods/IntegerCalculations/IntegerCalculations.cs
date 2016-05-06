using System;
using System.Linq;

class IntegerCalculations
{
    private const int N = 5;

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
