/*Problem 6. The Biggest of Five Numbers
 • Write a program that finds the biggest of five numbers by using only five if statements.

Examples:
a    b     c   d    e     biggest
5    2     2   4    1     5 
-2   -22   1   0    0     1 
-2   4     3   2    0     4 
0   -2.5   0   5    5     5 
-3  -0.5 -1.1 -2    -0.1  -0.1 */

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        else
        {
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else
            {
                if (c > a && c > b && c > d && c > e)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    if (d > a && d > b && d > c && d > e)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}