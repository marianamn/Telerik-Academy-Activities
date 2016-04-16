/*Problem 4. Number Comparer
• Write a program that gets two numbers from the console and prints the greater of them.
• Try to implement this without if statements.

Examples:
a       b     greater
5       6     6 
10      5     10 
0       0     0 
-5      -2    -2 
1.5     1.6   1.6 */

using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        bool greaterNumber = a > b;
        Console.WriteLine("{0}", greaterNumber ? a : b);
    }
}