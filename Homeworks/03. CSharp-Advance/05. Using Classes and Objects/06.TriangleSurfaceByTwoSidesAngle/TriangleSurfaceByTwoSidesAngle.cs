namespace _06.TriangleSurfaceByTwoSidesAngle
{
    using System;

    public class TriangleSurfaceByTwoSidesAngle
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", SurfaceByTwoSidesAndAngle(a, b, angle));
        }

        static double SurfaceByTwoSidesAndAngle(double a, double b, double angle)
        {
            double radian = (Math.PI * angle) / 180;
            double surface = (b * a * Math.Sin(radian)) / 2;
            return surface;
        }
    }
}
