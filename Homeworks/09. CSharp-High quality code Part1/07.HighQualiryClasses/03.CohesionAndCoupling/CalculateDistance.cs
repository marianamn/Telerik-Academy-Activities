using System;

namespace CohesionAndCoupling
{
    public class CalculateDistance
    {
        public static double CalculateDistance2D(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt(
                ((secondPointX - firstPointX) * (secondPointX - firstPointX)) + 
                ((secondPointY - firstPointY) * (secondPointY - firstPointY)));

            return distance;
        }

        public static double CalculateDistance3D(
            double firstPointX, 
            double firstPointY, 
            double firstPointZ, 
            double secondPointX, 
            double secondPointY, 
            double secondPointZ)
        {
            double distance = Math.Sqrt(
                ((secondPointX - firstPointX) * (secondPointX - firstPointX)) +
                ((secondPointY - firstPointY) * (secondPointY - firstPointY)) +
                ((secondPointZ - firstPointZ) * (secondPointZ - firstPointZ)));

            return distance;
        }
    }
}
