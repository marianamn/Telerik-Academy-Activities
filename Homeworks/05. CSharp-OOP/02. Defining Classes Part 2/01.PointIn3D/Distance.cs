namespace _01.PointIn3D
{
    using System;

    // problem - 3
    public class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt(((point1.X - point2.X) * (point1.X - point2.X)) +
                                        ((point1.Y - point2.Y) * (point1.Y - point2.Y)) +
                                        ((point1.Z - point2.Z) * (point1.Z - point2.Z)));

            return distance;
        }
    }
}
