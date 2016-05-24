/*Problem 2. Concatenate text files
 • Write a program that concatenates two text files into another text file.*/

using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader file = new StreamReader(@"..\..\..\Txt Files\Test.txt");
        StreamReader file2 = new StreamReader(@"..\..\..\Txt Files\Test2.txt");

        //File will be created in folder --> \Txt files
        StreamWriter concatenated = new StreamWriter(@"..\..\..\Txt Files\concatenated.txt");
        using (concatenated)
        {
            using (file)
            {
                string line = file.ReadLine();
                while (line != null) 
                 {
                     concatenated.WriteLine(line);
                     line = file.ReadLine(); 
                 } 
            }

            using (file2)
            {
                string line = file2.ReadLine();
                while (line != null)
                {
                    concatenated.WriteLine(line);
                    line = file2.ReadLine();
                }
            }
        }

        //File will be created in folder --> \Txt files
        Console.WriteLine("File is written.");

    }
}