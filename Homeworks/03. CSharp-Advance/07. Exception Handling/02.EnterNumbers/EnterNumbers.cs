namespace _02.EnterNumbers
{
    using System;
    using System.Linq;

    public class EnterNumbers
    {
        private const int Length = 10;

        public static void Main()
        {
            double[] numbers = ReadNumber(1, 100);

            bool increasing = false;

            try
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        increasing = true;
                    }
                    else
                    {
                        increasing = false;
                        break;
                    }
                }

                if (!increasing || numbers.Any(x => x < 0) || numbers.Any(x => x > 100))
                {
                    Console.WriteLine("Exception");
                }
                else
                {
                    Console.WriteLine("1 < {0} < 100", string.Join(" < ", numbers));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static double[] ReadNumber(int start, int end)
        {
            double[] numbers = new double[Length];

            for (int i = 0; i < Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}