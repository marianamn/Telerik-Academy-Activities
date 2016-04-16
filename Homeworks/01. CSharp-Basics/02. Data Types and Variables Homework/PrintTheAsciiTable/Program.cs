/*Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) 
and write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).

Note: You may need to use for-loops (learn in Internet how).*/

using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        for (int character = 33; character <= 126; character++)
        {
            char symbol = (char)character;
            Console.Write(symbol);
        }
    }
}