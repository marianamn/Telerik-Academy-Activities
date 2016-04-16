/*Problem 10. Point Inside a Circle & Outside of a Rectangle
 • Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
 if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

 Print inside circle if the point is inside the circle and outside circle if it's outside. 
 Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. 
 See the sample tests for a visual description.

Examples:
x      y      inside K & outside of R
2.5    2      outside circle outside rectangle 
0      1      inside circle inside rectangle
2.5    1      inside circle inside rectangle
1      2      inside circle outside rectangle 
*/

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        //Console.WriteLine("Circle has coordinates K({1, 1}, 1.5)");
        //Console.WriteLine("Rectangle has top=1, left=-1, width=6, height=2");
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        bool isPointInCircle = ((Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2)) <= Math.Pow(1.5,2));
        bool isPointInRegtangle = (pointX >= -1) && (pointX <= 5) && (pointY >= -1) && (pointY <= 1);

        if (isPointInCircle)
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }

        if (isPointInRegtangle)
        {
            Console.Write(" inside rectangle");
        }
        else
        {
            Console.Write(" outside rectangle");
        }

        Console.WriteLine();
    }
}