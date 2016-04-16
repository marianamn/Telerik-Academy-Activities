/*Problem 1. Declare Variables
• Declare five variables choosing for each of them the most appropriate of the types  
byte, sbyte, short, ushort, int, uint, long, ulong  to represent the following values:
52130, -115, 4825932, 97, -10000 .
• Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/


using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte fourthNumber = 97;
        short fifthNumber = -10000;
        Console.WriteLine("The first number {0} is type ushort and its maximum value is {1}", firstNumber, ushort.MaxValue);
        Console.WriteLine("The second number {0} is type sbyte and its minimum value is {1}", secondNumber, sbyte.MinValue);
        Console.WriteLine("The thitd number {0} is type int and its maximum value is {1}", thirdNumber, int.MaxValue);
        Console.WriteLine("The fourth number {0} is type byte and its maximum value is {1}", fourthNumber, byte.MaxValue);
        Console.WriteLine("The fifth number {0} is type short and its minimum value is {1}", fifthNumber, short.MinValue);

    }
}
