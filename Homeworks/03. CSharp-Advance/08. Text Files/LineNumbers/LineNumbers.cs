/*Problem 3. Line numbers
• Write a program that reads a text file and inserts line numbers in front of each of its lines.
• The result should be written to another text file.*/

using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader file = new StreamReader(@"..\..\..\Txt Files\Test.txt");

        //File will be created in folder --> \Txt files
        StreamWriter withLines = new StreamWriter(@"..\..\..\Txt Files\Test with lines num.txt");
        int count=0;
        using (withLines)
        {
            using (file)
            {
                string line = file.ReadLine();
                while (line != null) 
                 {
                     count++;
                     withLines.WriteLine("{0:D2}. {1}",count, line);
                     line = file.ReadLine(); 
                 } 
            }

        }

        //File will be created in folder --> \Txt files
        Console.WriteLine("File is written.");
    }
}
