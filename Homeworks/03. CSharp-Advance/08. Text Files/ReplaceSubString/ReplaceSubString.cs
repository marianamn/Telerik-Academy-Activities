/*Problem 7. Replace sub-string
• Write a program that replaces all occurrences of the sub-string  "start"  with the sub-string  
  "finish"  in a text file.
• Ensure it will work with large files (e.g.  100 MB ). */

/*
input file                          output file
start to replace sub-Strings        finish to replace sub-Strings
start to replace sub-Strings        finish to replace sub-Strings  
start to replace sub-Strings        finish to replace sub-Strings
start to replace sub-Strings        finish to replace sub-Strings
start to replace sub-Strings        finish to replace sub-Strings*/

using System;
using System.Text;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        //files are in folder -->Txt files
        StreamReader readFile = new StreamReader(@"..\..\..\Txt Files\Substring Replace.txt");

        StreamWriter writeFile = new StreamWriter(@"..\..\..\Txt Files\Substring Replace Output.txt");

        using (writeFile)
        {
            using (readFile)
            {
                for (string line = readFile.ReadLine(); line != null; line = readFile.ReadLine()) 
                 { 
                     string newLine = line.Replace("start", "finish");
                     writeFile.WriteLine(newLine); 
                 } 
            }
        }

        Console.WriteLine("Replacing done!");
    }
}
