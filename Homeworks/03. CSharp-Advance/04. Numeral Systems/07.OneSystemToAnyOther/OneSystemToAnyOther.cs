using System;

class OneSystemToAnyOther
{
    static void Main(string[] args)
    {
        int baseToConvertFrom = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int baseToConvertTo = int.Parse(Console.ReadLine());

        long decimalNumber = ConvertToDecimal(number, baseToConvertFrom);

        Console.WriteLine(ConvertFromDecimal(decimalNumber, baseToConvertTo));
    }

    static long ConvertToDecimal(string number, int baseToConvertFrom)
    {
        long result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += long.Parse(number[i].ToString()) * (long)Math.Pow(baseToConvertFrom, number.Length - 1 - i);
            }
            else
            {
                result += (number[i] - 'A' + 10) * (long)Math.Pow(baseToConvertFrom, number.Length - 1 - i);
            }
        }

        return result;
    }

    static string ConvertFromDecimal(long number, int baseToConvertTo)
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
                if (number % baseToConvertTo < 10)
                {
                    result = number % baseToConvertTo + result;
                }
                else
                {
                    result = (char)(number % baseToConvertTo + 'A' - 10) + result;
                }
                number /= baseToConvertTo;
            }
        }

        return result;
    }
}


// second way - only works when bases are between 2 and 16
//namespace _07.OneSystemToAnyOther
//{
//    using System;
//
//    public class OneSystemToAnyOther
//    {
//        public static void Main()
//        {
//            int baseToConvertFrom = int.Parse(Console.ReadLine());
//            string number = Console.ReadLine();
//            int baseToConvertTo = int.Parse(Console.ReadLine());
//
//            long numberConvertedToDecimal = ConvertedToDecimal(number, baseToConvertFrom);
//            string numberConvertedFromDecimal = ConvertedFromDecimal(numberConvertedToDecimal, baseToConvertTo);
//
//            Console.WriteLine(numberConvertedFromDecimal);
//        }
//
//        private static long ConvertedToDecimal(string number, int baseToConvertFrom)
//        {
//            long result = 0;
//
//            for (int i = 0; i < number.Length; i++)
//            {
//                string num = number[number.Length - 1 - i].ToString();
//
//                if (int.Parse(num) > 9)
//                {
//                    switch (num)
//                    {
//                        case "A": num = "10"; break;
//                        case "B": num = "11"; break;
//                        case "C": num = "12"; break;
//                        case "D": num = "13"; break;
//                        case "E": num = "14"; break;
//                        case "F": num = "15"; break;
//                    }
//                }
//
//                result += long.Parse(num) * (long)Math.Pow(baseToConvertFrom, i);
//            }
//
//            return result;
//        }
//
//        private static string ConvertedFromDecimal(long number, int baseToConvertTo)
//        {
//            string result = string.Empty;
//            string remainders = string.Empty;
//
//            while (number > 0)
//            {
//                long remainder = number % baseToConvertTo;
//
//                if (remainder <= 9)
//                {
//                    remainders += remainder.ToString();
//                }
//                else
//                {
//                    switch (remainder)
//                    {
//                        case 10: remainders += "A"; break;
//                        case 11: remainders += "B"; break;
//                        case 12: remainders += "C"; break;
//                        case 13: remainders += "D"; break;
//                        case 14: remainders += "E"; break;
//                        case 15: remainders += "F"; break;
//                    }
//                }
//
//                number /= baseToConvertTo;
//            }
//
//            for (int i = remainders.Length - 1; i >= 0; i--)
//            {
//                result += remainders[i];
//            }
//
//            return result;
//        }
//    }
//}
