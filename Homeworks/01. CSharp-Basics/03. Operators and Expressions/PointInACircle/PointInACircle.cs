/*Problem 7. Point in a Circle
Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) is inside a circle K({0, 0}, 2) 
- the center has coordinates (0, 0) and the circle has radius 2. The program should then print "yes DISTANCE" if the point is inside the circle 
or "no DISTANCE" if the point is outside the circle.

In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.

Examples:
Input	Output
-2
0	    yes 2.00
-1
2	    no 2.24
1.5
-1	    yes 1.80
-1.5
-1.5	no 2.12
100
-30	    no 104.40
0
0	    yes 0.00
0.2
-0.8	yes 0.82
0.9
-1.93	no 2.13
1
1.655	yes 1.93
0
1	    yes 1.00
*/

using System;

class PointInACircle
{
    static void Main()
    {
        //Point in cercle formula:  ((xp − xc )^2 + (yp − yc )^2) <= r^2
       
        int circleX = 0;
        int circleY = 0;
        int circleRadius = 2;

        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        bool isPointInCircle = ((Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2)) <= Math.Pow(circleRadius, 2));
        double distance = Math.Sqrt(Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2));

        if (isPointInCircle)
        {
            Console.WriteLine("yes {0:f2}", distance);
        }
        else
        {
            Console.WriteLine("no {0:f2}", distance);
        }
        
    }
}