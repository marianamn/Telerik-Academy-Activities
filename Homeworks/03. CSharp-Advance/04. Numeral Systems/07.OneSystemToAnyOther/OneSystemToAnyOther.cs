using System;

class OneSystemToAnyOther
{
    static void Main(string[] args)
    {

        short baseToConvertFrom = short.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        short baseToConvertTo = short.Parse(Console.ReadLine());

        string decimalNumber = ConvertToDecimal(number, baseToConvertFrom);

        string result = ConvertFromDecimal(decimalNumber, baseToConvertTo);
        Console.WriteLine(result.ToUpper().TrimStart('0'));
    }

    static long Power(long number, long power)
    {
        long result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }

    static string ConvertToDecimal(string number, short baseToConvertFrom)
    {
        long result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            long digit = 0;

            if (char.IsDigit(number[i]))
            {
                digit += long.Parse(number[i].ToString());
            }
            else
            {
                digit += (number[i] - 'A' + 10);
            }

            result += digit * Power(baseToConvertFrom, number.Length - i - 1);
        }

        return result.ToString();
    }

    static string ConvertFromDecimal(string numb, short baseToConvertTo)
    {
        long number = long.Parse(numb);
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