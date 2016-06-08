namespace _01.PointIn3D
{
    using System;
    using System.Collections.Generic;

    public class PointIn3DStart
    {
        public static void Main()
        {
            Console.WriteLine(
                              "Distance between point a (2, 3, 3.4) and point b (3, 4, 5) is {0:F2}",
                              Distance.CalculateDistance(new Point3D(2, 3, 3.4), new Point3D(3, 4, 5)));
            Console.WriteLine();

            // problem 4
            List<Point3D> listOfPoints = new List<Point3D>
            {
                new Point3D(2, 3, 3.4),
                new Point3D(3, 4, 5),
                new Point3D(1.4, -2, 0),
                new Point3D(3, 4, 5)
            };

            Path exampleListPoints = new Path(listOfPoints);
            PathStorage.SavePaths(exampleListPoints);
            Console.WriteLine("Points has been written in txt file in the main project folder!");
            Console.WriteLine();
            Console.WriteLine("Data loaded from the .txt file:");
            PathStorage.LoadPaths(exampleListPoints);
        }
    }
}
