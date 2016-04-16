/*Problem 9. Trapezoids
• Write an expression that calculates trapezoid's area by given sides a and b and height h. 
The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
Output a single line containing a single value - the area of the trapezoid. Output the area with exactly 7-digit precision after the floating point.

Examples:
a       b        h       area
5       7        12      72.0000000 
2       1        33      49.5000000 
8.5     4.3      2.7     17.2800000
100     200      300     45000.0000000 
0.222   0.333    0.555   0.1540125 */

using System;

class Trapezoids
{
    static void Main()
    {
        //trapezoid area formula = ((a+b)/2)*h
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("{0:F7}", trapezoidArea);
    }
}