using System;

class GetLargestNumber
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        if (a > c)
        {
            GetMax(a, b);
        }
        else
        {
            GetMax(b, c);
        }
    }

    static void GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;

        if (firstNumber >= secondNumber)
        {
           max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }

        Console.WriteLine(max);
    }
}