using System;
using System.Diagnostics;

namespace _03.AdvancedMathOperations
{
    public class Startup
    {
        private const int RepeatCount = 1000000;
        private const string FloatMessage = "Measure Float Advanced Math Operations";
        private const string DoubleMessage = "Measure Double Advanced Math Operations";
        private const string DecimalMessage = "Measure Decimal Advanced Math Operations";

        public static void Main()
        {
            MeasuringFloatAdvancedMathOperations();
            MeasuringDoubleAdvancedMathOperations();
            MeasuringDecimalAdvancedMathOperations();
        }

        private static void MeasuringFloatAdvancedMathOperations()
        {
            float number = 0.05f;

            MeasureOperations(number, FloatMessage);
        }

        private static void MeasuringDoubleAdvancedMathOperations()
        {
            double number = 0.05;

            MeasureOperations(number, DoubleMessage);
        }

        private static void MeasuringDecimalAdvancedMathOperations()
        {
            decimal number = 0.05m;

            MeasureOperations((double)number, DecimalMessage);
        }

        private static void MeasureOperations(dynamic number, string message)
        {
            Console.WriteLine("======={0}=======", message);
            Console.WriteLine();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                AdvancedMathOperations.SquareRoot(number);
            }

            stopWatch.Stop();
            Console.WriteLine("Square Root execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                AdvancedMathOperations.NaturalLogarithm(number);
            }

            stopWatch.Stop();
            Console.WriteLine("Natural Logarithm execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                AdvancedMathOperations.Sinus(number);
            }

            stopWatch.Stop();
            Console.WriteLine("Sinus execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            Console.WriteLine();
        }
    }
}
