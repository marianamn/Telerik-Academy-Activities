using System;

namespace _01.CalculateMethodsTask
{
    public class Methods
    {
        public static void Main()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Console.WriteLine(CalculateTriangleArea(sideA, sideB, sideC));

            int digit = 5;
            Console.WriteLine(PresentDigitsAsWord(digit));

            int[] numbers = new int[] { 5, -1, 3, 2, 14, 2, 3 };
            Console.WriteLine(FindMaximalNumberInArray(numbers));

            PrintNumberInSpecificFormat(1.3, "floating");
            PrintNumberInSpecificFormat(0.75, "percent");
            PrintNumberInSpecificFormat(2.30, "rightAlaigh");

            double firstPointX = 3;
            double firstPointY = -1;
            double secondPointX = 3;
            double secondPointY = 2.5;
            Console.WriteLine(CalculateDistanceBetweenTwoPoints(firstPointX, firstPointY, secondPointX, secondPointY));

            bool horizontal = IsHorizontal(-1, 2.5);
            bool vertical = IsVertical(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }

        private static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            bool validTriangleSides = sideA <= 0 || sideB <= 0 || sideC <= 0;
            bool sumOfTwoTriangleSidesBiggerThanThird = ((sideA + sideB) > sideC) ||
                ((sideB + sideC) > sideA) || ((sideA + sideC) > sideB);

            if (!validTriangleSides && !sumOfTwoTriangleSidesBiggerThanThird)
            {
                throw new Exception("Sides should be positive numbers and the sum of each two sides must be greater than third.");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

            return area;
        }

        private static string PresentDigitsAsWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new Exception("Invalid digit!");
            }
        }

        private static int FindMaximalNumberInArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new Exception("Invalid number!");
            }

            int maxNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        private static void PrintNumberInSpecificFormat(object number, string format)
        {
            switch (format)
            {
                case "floating":
                    Console.WriteLine("{0:F2}", number);
                    break;
                case "percent":
                    Console.WriteLine("{0:P0}", number);
                    break;
                case "rightAlaigh":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new Exception("Infalid format!");
            }
        }

        private static double CalculateDistanceBetweenTwoPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt(
                ((secondPointX - firstPointX) * (secondPointX - firstPointX)) + 
                ((secondPointY - firstPointY) * (secondPointY - firstPointY)));

            return distance;
        }

        private static bool IsHorizontal(double firstPointY, double secondPointY)
        {
            bool isPointHorizontal = false;

            if (firstPointY == secondPointY)
            {
                isPointHorizontal = true;
            }

            return isPointHorizontal;
        }

        private static bool IsVertical(double firstPointX, double secondPointX)
        {
            bool isPointVertical = false;

            if (firstPointX == secondPointX)
            {
                isPointVertical = true;
            }

            return isPointVertical;
        }
    }
}
