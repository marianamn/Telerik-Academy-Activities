// Write a program that reads from the console a sequence of positive integer numbers.
// 
// The sequence ends when empty line is entered.
// Calculate and print the sum and average of the elements of the sequence.
// Keep the sequence in List<int>.

namespace PrintSumOfElementsInList
{
    using System;
    using System.Collections.Generic;

    public class PrintSumAndAvrgOfElementsInList
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            List<int> numbers = ReadNumbersFromConsole();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            double avrg = sum / numbers.Count;

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Avrg = {0:F2}", avrg);
        }

        private static List<int> ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter numbers:");

            List<int> numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != EndOfInput)
                {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    break;
                }       
            }

            return numbers;
        }
    }
}
