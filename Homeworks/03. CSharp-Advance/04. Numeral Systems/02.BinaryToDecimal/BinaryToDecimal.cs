namespace _02.BinaryToDecimal
{
    using System;

    public class BinaryToDecimal
    {
        public static void Main()
        {
            string binaryNumber = Console.ReadLine();

            long decimalNumber = ConvertBinnaryToDecimal(binaryNumber);

            Console.WriteLine(decimalNumber);
        }

        private static long ConvertBinnaryToDecimal(string binaryNumber)
        {
            long number = 0;
            int numericBase = 2;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                number += long.Parse(binaryNumber[binaryNumber.Length - 1 - i].ToString()) * (long)Math.Pow(numericBase, i);
            }

            return number;
        }
    }
}
