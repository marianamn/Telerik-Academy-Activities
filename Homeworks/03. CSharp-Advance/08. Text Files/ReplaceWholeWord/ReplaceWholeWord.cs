/*Problem 8. Replace whole word
 • Modify the solution of the previous problem to replace only whole words (not strings).*/

using System;
using System.Text;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        //files are in folder -->Txt files
        StreamReader readFile = new StreamReader(@"..\..\..\Txt Files\Substring Replace.txt");

        StreamWriter writeFile = new StreamWriter(@"..\..\..\Txt Files\Word Replace Output.txt");

        using (writeFile)
        {
            using (readFile)
            {
                for (string line = readFile.ReadLine(); line != null; line = readFile.ReadLine())
                {
                    for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                    {
                        if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                        {
                            line = line.Insert(i, "finish").Remove(i + 6, 5);
                        }
                    }
                    writeFile.WriteLine(line);

                }
            }

            Console.WriteLine("Replacing done!");
        }
    }
}
