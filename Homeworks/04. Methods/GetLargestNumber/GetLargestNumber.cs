/*Problem 2. Get largest number
• Write a method  GetMax()  with two parameters that returns the larger of two integers.
• Write a program that reads  3  integers from the console and prints the largest of them using the 
  method  GetMax() .*/


using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());

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
        int max;
        if (firstNumber >= secondNumber)
        {
           max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        Console.WriteLine("Maximal number is: {0}", max);
    }
}