using System;

namespace _02.VisitCellRefactoring
{
    public class Startup
    {
        private const double MinX = 0;
        private const double MaxX = 30;
        private const double MinY = -10;
        private const double MaxY = 5;

        public static void Main()
        {
            double coordinateX = 2.5;
            double coordinateY = 1;

            bool isCellCouldBeVisited = CheckVisitedCell(coordinateX, coordinateY);

            if (isCellCouldBeVisited)
            {
                VisitCell();
            }
            else
            {
                Console.WriteLine("Coordinates are out of range or cell could not be visited");
            }
        }

        private static bool CheckVisitedCell(double coordinateX, double coordinateY)
        {
            bool isXInRange = (coordinateX >= MinX) && (coordinateX <= MaxX);
            bool isYInRange = (coordinateY >= MinY) && (coordinateY <= MaxY);
            bool canBeVisited = true;

            bool statement = isXInRange && isYInRange && !canBeVisited;

            if (statement)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("The cell can be visited so Do something!");
        }
    }
}
