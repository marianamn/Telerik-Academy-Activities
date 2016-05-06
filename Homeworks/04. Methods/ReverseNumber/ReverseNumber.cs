using System;
using System.Text;

class ReverseNumber
{
    static void Main()
    {
        string number = Console.ReadLine();

        if (number[0] != '-')
        {
            Console.WriteLine(NumberReverse(number));
        }
        else
        {
            Console.WriteLine("-{0}", NumberReverse(number));
        }
        
    }

    static StringBuilder NumberReverse(string number)
    {
        StringBuilder reversedNumber = new StringBuilder();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversedNumber.Append(number[i]);
        }

        return reversedNumber;
    }
}

