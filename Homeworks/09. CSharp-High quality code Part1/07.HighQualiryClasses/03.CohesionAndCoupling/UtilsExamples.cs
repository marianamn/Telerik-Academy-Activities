using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileExtention.GetFileExtension("example"));
            Console.WriteLine(FileExtention.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtention.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtention.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtention.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtention.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalculateDistance.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalculateDistance.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure = new Figure3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}