/*Problem 11. Prefix "test"
• Write a program that deletes from a text file all words that start with the prefix  test.
• Words contain only the symbols  0…9 ,  a…z ,  A…Z ,  _ .  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        //files are in folder -->Txt files

        StringBuilder sb = new StringBuilder();

        DeleteWords(sb);
        WriteTheFile(sb);
        Console.WriteLine("Prefix test has been removed");
    }


    private static void WriteTheFile(StringBuilder sb)
    {
        StreamWriter writeFile = new StreamWriter(@"..\..\..\Txt Files\Prefix test Output.txt");
        using (writeFile)
        {
            writeFile.Write(sb);
        }
    }

    private static void DeleteWords(StringBuilder sb)
    {
        StreamReader readFile = new StreamReader(@"..\..\..\Txt Files\Prefix test.txt");
        using (readFile)
        {
            string line = string.Empty;

            while ((line = readFile.ReadLine()) != null)
            {
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    if (word.Length <= 3)
                    {
                        sb.Append(word).Append(' ');
                    }
                    else if ((word[0] == 't') && (word[1] == 'e') && (word[2] == 's') && (word[3] == 't'))
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append(word).Append(' ');
                    }
                }

                if (!readFile.EndOfStream)
                {
                    sb.Append("\r\n");
                }
            }
        }
    }
}
