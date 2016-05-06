using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string[] lengths = Console.ReadLine().Split(' ');
        int n = int.Parse(lengths[0]);
        int m = int.Parse(lengths[1]);

        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');

        int[] firstArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(firstLine[i]);
        }

        int[] secondArray = new int[m];

        for (int i = 0; i < m; i++)
        {
            secondArray[i] = int.Parse(secondLine[i]);
        }

        int[] sumArray = SumArraysDigits(firstArray, secondArray);

        Console.WriteLine(string.Join(" ", sumArray));
    }

    private static int[] SumArraysDigits(int[] firstArray, int[] secondArray)
    {
        int maxLenght = Math.Max(firstArray.Length, secondArray.Length);
        int[] sums = new int[maxLenght];
        int sum = 0;

        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            sum = firstArray[i] + secondArray[i];

            if (sum / 10 == 0)
            {
                sums[i] = sum;
            }
            else
            {
                sums[i] = sum % 10;
            }
        }

        if (firstArray.Length > secondArray.Length)
        {
            for (int i = secondArray.Length; i < firstArray.Length; i++)
            {
                sums[i] = firstArray[i];
            }
        }
        else
        {
            for (int i = firstArray.Length; i < secondArray.Length; i++)
            {
                sums[i] = secondArray[i];
            }
        }

        return sums;
    }
}
