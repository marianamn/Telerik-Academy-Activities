using System;

namespace _01.RotateFigure
{
    public class Startup
    {
        public static void Main()
        {
            double width = 2.5;
            double height = 3;
            Figure rectangle = new Figure(width, height);

            double angleToRotate = 30;
            Figure shape = Figure.RotateFigure(rectangle, angleToRotate);

            Console.WriteLine(string.Format("width: {0:F2}, height: {1:F2}", shape.Width, shape.Height));
        }
    }
}
