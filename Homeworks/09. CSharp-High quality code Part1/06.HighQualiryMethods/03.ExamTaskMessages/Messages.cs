using System;
using System.Numerics;

namespace _03.ExamTaskMessages
{
    public class Messages
    {
        private const int CodeCharslength = 3;

        public static void Main()
        {
            string firstCode = Console.ReadLine();
            char sign = char.Parse(Console.ReadLine());
            string secondCode = Console.ReadLine();

            string convertedCode = ConvertCodesToStringOfNumbers(firstCode, secondCode, sign);

            string convertToText= ConvertNumbersToText(convertedCode);
            Console.WriteLine(convertToText);
        }

        private static string ConvertCodesToStringOfNumbers(string firstCode, string secondCode, char sign)
        {
            BigInteger firstNumber = FindNumber(firstCode);
            BigInteger secondNumber = FindNumber(secondCode);

            BigInteger result = 0;

            switch (sign)
            {
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
            }

            return result.ToString();
        }

        private static BigInteger FindNumber(string firstCode)
        {
            string result = string.Empty;

            for (int i = 0; i <= firstCode.Length - CodeCharslength; i++)
            {
                string code = firstCode.Substring(i, CodeCharslength);

                switch (code)
                {
                    case "cad":
                        result += 0;
                        break;
                    case "xoz":
                        result += 1;
                        break;
                    case "nop":
                        result += 2;
                        break;
                    case "cyk":
                        result += 3;
                        break;
                    case "min":
                        result += 4;
                        break;
                    case "mar":
                        result += 5;
                        break;
                    case "kon":
                        result += 6;
                        break;
                    case "iva":
                        result += 7;
                        break;
                    case "ogi":
                        result += 8;
                        break;
                    case "yan":
                        result += 9;
                        break;
                }

                i += 2;
            }

            return BigInteger.Parse(result);
        }

        private static string ConvertNumbersToText(string numbers)
        {
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i] - '0';

                switch (number)
                {
                    case 0:
                        result += "cad";
                        break;
                    case 1:
                        result += "xoz";
                        break;
                    case 2:
                        result += "nop";
                        break;
                    case 3:
                        result += "cyk";
                        break;
                    case 4:
                        result += "min";
                        break;
                    case 5:
                        result += "mar";
                        break;
                    case 6:
                        result += "kon";
                        break;
                    case 7:
                        result += "iva";
                        break;
                    case 8:
                        result += "ogi";
                        break;
                    case 9:
                        result += "yan";
                        break;
                }
            }

            return result;
        }
    }
}
