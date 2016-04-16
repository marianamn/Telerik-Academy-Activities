/*Problem 7. Sum of 5 Numbers
 • Write a program that enters 5 numbers (given in a single line, separated by a space),
 calculates and prints their sum.

Examples:
numbers             sum
1 2 3 4 5           15 
10 10 10 10 10      50 
1.5 3.14 8.2 -1 0   11.84          */

using System;
class SumOfFiveNumbers
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}


//using System;
//class SumOfFiveNumbers
//{
//    static void Main()
//    {
//        Console.WriteLine("Entered 5 numbers in a single line, separated by a space");
//        string input = Console.ReadLine();
//        string[] fiveNumbers = input.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//
//        double sum = 0;
//        if (fiveNumbers.Length < 5)
//        {
//            Console.WriteLine("Invalid input!");
//        }
//        else
//        {
//            for (int i = 0; i < fiveNumbers.Length; i++)
//            {
//                sum += double.Parse(fiveNumbers[i]);
//            }
//            Console.WriteLine("Sum of numbers = {0}", sum);
//        }
//    }
//}