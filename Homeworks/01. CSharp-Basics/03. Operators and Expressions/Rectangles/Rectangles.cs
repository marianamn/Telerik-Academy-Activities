/*Problem 4. Rectangles
 • Write an expression that calculates rectangle’s perimeter and area by given width and height.

Examples:
width   height  perimeter  area
3       4       14         12 
2.5     3       11         7.5 
5       5       20         25 
*/

using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);
        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}

//using System;
//
//class Rectangles
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter width:");
//        double width = double.Parse(Console.ReadLine());
//        Console.WriteLine("Enter height:");
//        double height = double.Parse(Console.ReadLine());
//
//        if (width <= 0 || height <= 0)
//        {
//            Console.WriteLine("Not valid width or height!");
//        }
//        else
//        {
//            double perimeter = 2 * (width + height);
//            double area = width * height;
//            Console.WriteLine("Rectangle's perimeter is {0}.", perimeter);
//            Console.WriteLine("Rectangle's erea is {0}.", area);
//        }
//    }
//}