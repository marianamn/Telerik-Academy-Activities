/*Problem 3. Circle Perimeter and Area
• Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted 
  with 2 digits after the decimal point.
  You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision

Examples:
r        perimeter    area
2        12.57        12.57 
3.5      21.99        38.48   */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double pi = Math.PI;
        double perimeter = 2 * pi * r;
        double area = pi * Math.Pow(r, 2);

        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
    }
}