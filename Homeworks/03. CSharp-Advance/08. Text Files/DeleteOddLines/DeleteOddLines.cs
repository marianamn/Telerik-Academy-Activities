/*Problem 9. Delete odd lines
• Write a program that deletes from given text file all odd lines.
• The result should be in the same file. */

/*
Initial file    Output file
Deleeting       Deleeting
odd             lines
lines           file
from            save
file            the
and             file
save
in
the
same
file                            */


using System;
using System.Collections.Generic;
using System.IO;

    class DeleteOddLines
    {
        static void Main()
        {
            //The File (Del odd lines) is located in folder --> \Txt files
            StreamReader file = new StreamReader(@"..\..\..\Txt Files\Del odd lines.txt");

            List<string> evenLines = new List<string>();

            using (file)
            {
                int lineNum = 0;
                string line = file.ReadLine();
               
                while (line != null)
                {
                    if (lineNum % 2 == 0)
                    {
                        evenLines.Add(line);
                    }
                    lineNum++;
                    line = file.ReadLine();
                }
            }


            //The File --> Del odd lines, will be rewrited and saved in folder --> \Txt files
            StreamWriter fileOutput = new StreamWriter(@"..\..\..\Txt Files\Del odd lines.txt");

            using (fileOutput)
            {
                for (int i = 0; i < evenLines.Count; i++)
                {
                    fileOutput.WriteLine(evenLines[i]);
                }
            }
            Console.WriteLine("Odd lines removed!");
        }
}
