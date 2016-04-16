/*Problem 3. Divide by 7 and 5
 • Write a Boolean expression that checks for given integer if it can be divided (without remainder)
 by  7  and  5  at the same time.

Examples:
n       Divided by 7 and 5?
3       false 
0       false 
5       false 
7       false 
35      true 
140     true 
*/

using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        //Console.WriteLine("Enter integer number to check:");
        int number = int.Parse(Console.ReadLine());

        bool dividableBySeven = number % 7 == 0;
        bool dividableByFive = number % 5 == 0;
        bool dividableBySevenAndFive = dividableBySeven && dividableByFive;

        if (dividableBySevenAndFive)
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}