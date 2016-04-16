/*Problem 14. Modify a Bit at Given Position
• We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
• Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  
  at the position  p  from the binary representation of  n  while preserving all other bits in  n .

Examples:
n       binary representation of n     p    v    binary result       result
5       00000000 00000101              2    0    00000000 00000001   1 
0       00000000 00000000              9    1    00000010 00000000   512 
15      00000000 00001111              1    1    00000000 00001111   15 
5343    00010100 11011111              7    0    00010100 01011111   5215 
62241   11110011 00100001              11   0    11110011 00100001   62241        */


using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitToPeplace = int.Parse(Console.ReadLine());

        if (bitToPeplace == 0)
        {
            number = (number & ~((ulong)1 << position));
        }
        else 
        {
            number = (number | ((ulong)1 << position));
        }

        Console.WriteLine(number);
    }
}


//user UI
//using System;

//class ModifyABitAtGivenPosition
//{
//    static void Main()
//    {
//        Console.WriteLine("Type number:");
//        int number = int.Parse(Console.ReadLine());
//        Console.WriteLine("Type position:");
//        int position = int.Parse(Console.ReadLine());
//        Console.WriteLine("Type byte 0 or 1 to replace:");
//        int bitToPeplace = int.Parse(Console.ReadLine());
//        Console.WriteLine("Binary representation of number {0} is {1}", number,
//                          Convert.ToString(number, 2).PadLeft(16, '0'));
//
//        if (bitToPeplace == 0)
//        {
//            number = (number & ~(1 << position));
//        }
//        else
//        {
//            number = (number | (1 << position));
//        }
//        Console.WriteLine("Binary representation of the New number {0} is {1}", number,
//                          Convert.ToString(number, 2).PadLeft(16, '0'));
//        Console.WriteLine("The New number is {0}", number);
//    }
//}