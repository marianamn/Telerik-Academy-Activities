namespace _01.DecimalToBinary
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string result = ConvertDecimalToBinary(n);

            Console.WriteLine(result);
        }

        private static string ConvertDecimalToBinary(int number)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }
    }
}
