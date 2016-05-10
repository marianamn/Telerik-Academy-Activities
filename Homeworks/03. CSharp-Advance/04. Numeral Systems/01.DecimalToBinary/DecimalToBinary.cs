namespace _01.DecimalToBinary
{
    using System;

    public class DecimalToBinary
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            string result = ConvertDecimalToBinary(n);

            Console.WriteLine(result);
        }

        private static string ConvertDecimalToBinary(long number)
        {
            string result = string.Empty;

            if (number == 0)
            {
                result = "0";
            }
            else
            {
                while (number > 0)
                {
                    result = number % 2 + result;
                    number /= 2;
                }
            }

            return result;
        }
    }
}
