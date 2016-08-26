using System;

namespace _02.PrintStatistic
{
    public class Startup
    {
        public static void Main()
        {
            double[] numbers = { 2.3, 5, 4.5, 5 };
            PrintStatistic(numbers);
        }

        private static void PrintStatistic(double[] numbers)
        {
            double maximalNumber = FindMaximal(numbers);
            Print("Maximal: ", maximalNumber);

            double minimalNumber = FindMinimal(numbers);
            Print("Minimal: ", minimalNumber);

            double averageNumber = FindAverage(numbers);
            Print("Avarage: ", averageNumber);
        }

        private static double FindMaximal(double[] numbers)
        {
            double maximalNumber = numbers[1];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximalNumber)
                {
                    maximalNumber = numbers[i];
                }
            }

            return maximalNumber;
        }

        private static double FindMinimal(double[] numbers)
        {
            double minimalNumber = numbers[1];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minimalNumber)
                {
                    minimalNumber = numbers[i];
                }
            }

            return minimalNumber;
        }

        private static double FindAverage(double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;

            return average;
        }

        private static void Print(string massage, double number)
        {
            Console.WriteLine(massage + number);
        }
    }
}
