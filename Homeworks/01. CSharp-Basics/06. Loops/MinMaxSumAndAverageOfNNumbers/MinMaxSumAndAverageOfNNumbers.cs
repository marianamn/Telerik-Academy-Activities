/* Problem 3. Min, Max, Sum and Average of N Numbers
• Write a program that reads from the console a sequence of  n  integer numbers and returns 
the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
• The output is like in the examples below.

Example 1:
input    output
3        min = 1 
2        max = 5 
5        sum = 8 
1        avg = 2.67 

Example 2:
input    output
2        min = -1 
-1       max = 4 
4        sum = 3 
         avg = 1.50    */


using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;
        double avg = 0;
        
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            double number = double.Parse(Console.ReadLine());

            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
            avg = sum / input;
        }

        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}