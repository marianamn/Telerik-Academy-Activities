/*Problem 6. Save sorted names
• Write a program that reads a text file containing a list of strings, sorts them and saves them to 
  another text file.

Example:
input.txt                 output.txt
 Ivan                     George 
 Peter                    Ivan
 Maria                    Maria
 George                   Peter  */

using System;
using System.Linq;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        StreamReader text = new StreamReader(@"..\..\..\Txt Files\List with names.txt");

        //File will be created in folder --> \Txt files
        StreamWriter sortedTex = new StreamWriter(@"..\..\..\Txt Files\List with sorted names.txt");

        string[] sorted = new string[4];

        using (text)
        {
            using (sortedTex)
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    string line = text.ReadLine();
                    sorted[i] = line;
                }

                Array.Sort(sorted);

                for (int i = 0; i < sorted.Length; i++)
                {
                     sortedTex.WriteLine(sorted[i]);
                }
            }
        }

        //File will be created in folder --> \Txt files
        Console.WriteLine("Sorted file has been written.");
    }
}
