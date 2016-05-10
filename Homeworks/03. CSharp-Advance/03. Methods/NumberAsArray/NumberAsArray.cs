using System;

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

        Console.WriteLine(string.Join(" ", sumArray).TrimEnd('0'));
    }

    private static int[] SumArraysDigits(int[] firstArray, int[] secondArray)
    {
        int maxLenght = Math.Min(firstArray.Length, secondArray.Length);
        int[] sums = new int[maxLenght+1];
        int sum = 0;
        int oneInMind = 0;

        for (int i = 0; i < maxLenght; i++)
        {
            sum = firstArray[i] + secondArray[i] + oneInMind;

            if (sum / 10 == 0)
            {
                sums[i] = sum;
            }
            else
            {
                sums[i] = sum % 10;
            }

            oneInMind = sum / 10;

            if (i == maxLenght - 1 && (firstArray[maxLenght-1] + secondArray[maxLenght-1]) / 10 != 0)
            {
                sums[maxLenght] = 1;
            }
        }

        if (firstArray.Length > secondArray.Length)
        {
            for (int i = secondArray.Length; i < firstArray.Length; i++)
            {
                int prevSum = secondArray[secondArray.Length - 1] + firstArray[secondArray.Length - 1];

                if (prevSum / 10 != 0)
                {
                    sums[i] = firstArray[i] + 1;
                }
                else
                {
                    sums[i] = firstArray[i];
                }
            }
        }
        else
        {
            for (int i = firstArray.Length; i < secondArray.Length; i++)
            {
                int prevSum2 = firstArray[firstArray.Length - 1] + secondArray[firstArray.Length - 1];

                if (prevSum2 / 10 != 0)
                {
                    sums[i] = secondArray[i] + 1;
                }
                else
                {
                    sums[i] = secondArray[i];
                }
            }
        }

        return sums;
    }
}
