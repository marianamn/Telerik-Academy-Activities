namespace _03.DecimalToHexadecimal
{
    using System;

    public class Program
    {
        private const int NumericBase = 16;

        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            string result = ConvertDecimalToHexadecimal(n);

            Console.WriteLine(result);
        }

        private static string ConvertDecimalToHexadecimal(long number)
        {
            string result = string.Empty;
            string remainders = string.Empty;

            while (number > 0)
            {
                long remainder = number % NumericBase;

                if (remainder <= 9)
                {
                    remainders += remainder.ToString();
                }
                else
                {
                    switch (remainder)
                    {
                        case 10: remainders += "A";
                            break;
                        case 11: remainders += "B";
                            break;
                        case 12: remainders += "C";
                            break;
                        case 13: remainders += "D";
                            break;
                        case 14: remainders += "E";
                            break;
                        case 15: remainders += "F";
                            break;
                    }
                }

                number /= NumericBase;
            }

            for (int i = remainders.Length - 1; i >= 0; i--)
            {
                result += remainders[i];
            }

            return result;
        }
    }
}
