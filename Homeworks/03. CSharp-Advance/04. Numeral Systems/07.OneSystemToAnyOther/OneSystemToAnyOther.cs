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