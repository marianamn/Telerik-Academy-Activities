/*Problem 3. Variable in Hexadecimal Format
• Declare an integer variable and assign it with the value  254  in hexadecimal format ( 0x## ).
• Use Windows Calculator to find its hexadecimal representation.
• Print the variable and ensure that the result is  254 .*/


using System;
class VariableInHexadecimalFormat
{
    static void Main()
    {
        int hexadecimalNumber = 0xFE;   //hexadecimal value of 254 is 0xFE
        Console.WriteLine("Decimal value of hexadecimal number 0xFE is {0}", hexadecimalNumber);
    }
}