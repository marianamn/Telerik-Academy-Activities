using System;
using System.Diagnostics;

namespace _02.CompareSimpleMaths
{
    public class Startup
    {
        private const int RepeatCount = 1000000;
        private const string IntMessage = "Measure Int Simple Maths operations";
        private const string LongMessage = "Measure Long Simple Maths operations";
        private const string FloatMessage = "Measure Float Simple Maths operations";
        private const string DoubleMessage = "Measure Double Simple Maths operations";
        private const string DecimalMessage = "Measure Decimal Simple Maths operations";

        public static void Main()
        {
            MeasuringIntSimpleMathOperations();
            MeasuringLongSimpleMathOperations();
            MeasuringFloatSimpleMathOperations();
            MeasuringDoubleSimpleMathOperations();
            MeasuringDecimalSimpleMathOperations();
        }

        private static void MeasuringIntSimpleMathOperations()
        {
            int firstNumber = 5;
            int secondNumber = 6;
            
            MeasureOperations(firstNumber, secondNumber, IntMessage);
        }

        private static void MeasuringLongSimpleMathOperations()
        {
            long firstNumber = 544444444;
            long secondNumber = 65;

            MeasureOperations(firstNumber, secondNumber, LongMessage);
        }

        private static void MeasuringFloatSimpleMathOperations()
        {
            float firstNumber = 5.05f;
            float secondNumber = 2.02f;

            MeasureOperations(firstNumber, secondNumber, FloatMessage);
        }

        private static void MeasuringDoubleSimpleMathOperations()
        {
            double firstNumber = 5.05;
            double secondNumber = 2.02;

            MeasureOperations(firstNumber, secondNumber, DoubleMessage);
        }

        private static void MeasuringDecimalSimpleMathOperations()
        {
            decimal firstNumber = 5.05m;
            decimal secondNumber = 2.02m;

            MeasureOperations(firstNumber, secondNumber, DecimalMessage);
        }

        private static void MeasureOperations(dynamic firstNumber, dynamic secondNumber, string message)
        {
            Console.WriteLine("======={0}=======", message);
            Console.WriteLine();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SimpleMathsOperations.Sum(firstNumber, secondNumber);
            }

            stopWatch.Stop();
            Console.WriteLine("Adding numbers execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SimpleMathsOperations.Substract(firstNumber, secondNumber);
            }

            stopWatch.Stop();
            Console.WriteLine("Substracting numbers execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SimpleMathsOperations.Multiply(firstNumber, secondNumber);
            }

            stopWatch.Stop();
            Console.WriteLine("Multiplying numbers execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < RepeatCount; i++)
            {
                SimpleMathsOperations.Divide(firstNumber, secondNumber);
            }

            stopWatch.Stop();
            Console.WriteLine("Dividing numbers execution time: {0}", stopWatch.Elapsed);
            stopWatch.Reset();

            Console.WriteLine();
        }
    }
}
