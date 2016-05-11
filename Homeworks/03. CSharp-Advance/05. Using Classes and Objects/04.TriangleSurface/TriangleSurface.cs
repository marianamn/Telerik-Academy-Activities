namespace _04.TriangleSurface
{
    using System;

    public class TriangleSurface
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", SurfaceBySideAndAltitudeToIt(a, h));
        }

        static double SurfaceBySideAndAltitudeToIt(double a, double h)
        {
            double surface = (a * h) / 2;
            return surface;
        }
    }
}
