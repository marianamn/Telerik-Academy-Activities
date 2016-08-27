using System;

namespace _03.FindNumber
{
    public class Startup
    {
        public static void Main()
        {
            int[] numbers = { 2, 3, 666, 6 };
            int searchValue = 666;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool numberIsFound = CompareNumbers(numbers[i], searchValue);

                if (numberIsFound)
                {
                    Console.WriteLine("Value Found");
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private static bool CompareNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
