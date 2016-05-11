namespace _05.TriangleSurfaceBySides
{
    using System;

    public class TriangleSurfaceBySides
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", SurfaceByThreeSides(a, b, c));
        }

        static double SurfaceByThreeSides(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double surface = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return surface;
        }
    }
}
