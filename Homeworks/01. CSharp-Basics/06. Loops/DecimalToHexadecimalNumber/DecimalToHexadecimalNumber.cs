/*Problem 16. Decimal to Hexadecimal Number
• Using loops write a program that converts an integer number to its hexadecimal representation.
• The input is entered as long. The output should be a variable of type string.
• Do not use the built-in .NET functionality.

Examples:
decimal         hexadecimal
254             FE 
6883            1AE3 
338583669684    4ED528CBB4       */

using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string hex = "";

        while (input > 0)
        {
            switch (input % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: hex += input % 16; break;
                case 10: hex += "A"; break;
                case 11: hex += "B"; break;
                case 12: hex += "C"; break;
                case 13: hex += "D"; break;
                case 14: hex += "E"; break;
                case 15: hex += "F"; break;
            }
            input /= 16;
        }

        string result = ""
           ;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            result += hex[i];
        }

        Console.WriteLine(result);
    }
}
