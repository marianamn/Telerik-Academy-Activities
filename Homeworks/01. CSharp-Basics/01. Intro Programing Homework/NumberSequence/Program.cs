/*Problem 9. Print a Sequence
• Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ...
Print each member on a separate line.
*/

using System;

class NumberSequence
{
    static void Main()
    {
        int currentNumber = 2;
        int nextNumber = 0;

        Console.WriteLine(currentNumber);

        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                nextNumber = currentNumber + 1;
            }
            else
            {
                nextNumber = -(currentNumber + 1);
            }

            Console.WriteLine(nextNumber);

            currentNumber = Math.Abs(nextNumber);
        }
    }
}


