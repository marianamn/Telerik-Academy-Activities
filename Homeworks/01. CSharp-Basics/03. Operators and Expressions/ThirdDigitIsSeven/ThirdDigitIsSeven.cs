/* Problem 5. Third Digit is 7?
 • Write an expression that checks for given integer if its third digit from right-to-left is  7 .

Examples:
n        Third digit 7?
5        false 
701      true 
9703     true 
877      false 
777877   false 
9999799  true */

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
    }
}