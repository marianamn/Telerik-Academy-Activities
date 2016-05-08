namespace _04.HexadecimalToDecimal
{
    using System;

    public class HexadecimalToDecimal
    {
        private const int NumericBase = 16;

        public static void Main()
        {
            string hexadecimalNumber = Console.ReadLine();

            long decimalNumber = ConvertHexadecimalToDecimal(hexadecimalNumber);

            Console.WriteLine(decimalNumber);
        }

        private static long ConvertHexadecimalToDecimal(string hexadecimalNumber)
        {
            long number = 0;

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                string num = hexadecimalNumber[hexadecimalNumber.Length - 1 - i].ToString();

                switch (num)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9": break;
                    case "A":
                        num = "10";
                        break;
                    case "B":
                        num = "11";
                        break;
                    case "C":
                        num = "12";
                        break;
                    case "D":
                        num = "13";
                        break;
                    case "E":
                        num = "14";
                        break;
                    case "F":
                        num = "15";
                        break;
                }

                number += long.Parse(num) * (long)Math.Pow(NumericBase, i);
            }

            return number;
        }
    }
}
