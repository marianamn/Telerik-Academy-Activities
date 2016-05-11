namespace _06.TriangleSurfaceByTwoSidesAngle
{
    using System;

    public class TriangleSurfaceByTwoSidesAngle
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double alpha = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", SurfaceByTwoSidesAndAngle(a, b, alpha));
        }

        static double SurfaceByTwoSidesAndAngle(double a, double b, double alpha)
        {
            double angle = Convert.ToDouble((Math.PI * alpha) / 180);
            double surface = Convert.ToDouble((b * a * Math.Sin(angle)) / 2);
            return surface;
        }
    }
}
