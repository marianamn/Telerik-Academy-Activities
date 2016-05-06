/*Problem 7. Reverse number
• Write a method that reverses the digits of given decimal number.

Example:
input   output
256     652    */


using System;
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine(DecimalNumberReverse(number));
        }
        else
        {
            Console.WriteLine("-{0}", DecimalNumberReverse(number));
        }
        
    }

    static string DecimalNumberReverse(decimal num)
    {
        string array = "";
        if (num<0)
        {
            num = -num;
        }

        while ((num / 10) > 0)
        {
            decimal lastDig = num % 10;
            array = array + lastDig + "";
            num = Math.Floor(num / 10); 
            if (num == 0)
            {
                break;
            }
            else
            {
                continue;
            }
        }
        return array;
        
    }
}

