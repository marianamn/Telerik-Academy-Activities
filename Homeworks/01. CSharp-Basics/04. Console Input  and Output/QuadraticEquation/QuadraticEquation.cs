/* Problem 6. Quadratic Equation
• Write a program that reads the coefficients  a ,  b  and  c  of a quadratic equation 
  ax^2 + bx + c = 0 and solves it (prints its real roots).

Examples:
a     b     c     roots
2     5     -3    x1=-3; x2=0.5 
-1    3     0     x1=3; x2=0 
-0.5  4    -8     x1=x2=4 
5     2     8     no real roots   */

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double x1 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
        double x2 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

        if ((Math.Pow(b, 2) - 4 * a * c) < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if ((Math.Pow(b, 2) - 4 * a * c) == 0)
            {
                Console.WriteLine("{0:F2}", x1);
            }
            else
            {
                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
        }
    }
}