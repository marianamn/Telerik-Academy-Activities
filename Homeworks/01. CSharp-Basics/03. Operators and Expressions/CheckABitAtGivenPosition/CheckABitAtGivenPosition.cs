/*Problem 13. Check a Bit at Given Position
 • Write a Boolean expression that returns if the bit at position  p  
  (counting from  0 , starting from the right) in given integer number  n , has value of 1.
  
Examples:
n       binary representation    p     bit @ p == 1
5       00000000 00000101        2     True 
0       00000000 00000000        9     False 
15      00000000 00001111        1     True 
5343    00010100 11011111        7     True 
62241   11110011 00100001        11    False           */


using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Type number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Type position:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of number {0} is {1}", number,
                          Convert.ToString(number, 2).PadLeft(16, '0'));
        int bit = (number >> position) & 1;
        bool resultBit = (bit==1);
        Console.WriteLine("Is the bit of position {0} equal to 1: {1}", position, resultBit);
    }
}