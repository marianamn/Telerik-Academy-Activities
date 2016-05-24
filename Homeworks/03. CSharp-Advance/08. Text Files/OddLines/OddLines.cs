/*Problem 1. Odd lines
• Write a program that reads a text file and prints on the console its odd lines.*/

using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader file = new StreamReader(@"..\..\..\Txt Files\Test.txt");
        using (file)
        {
            int lineNum = 0;
            string line = file.ReadLine();
            while (line != null)
            {
                
                if (lineNum % 2 != 0)
                {
                    Console.WriteLine("Line: {0} - {1}",lineNum, line);
                }
                lineNum++;
                line = file.ReadLine();
            }
        }

    }
}
