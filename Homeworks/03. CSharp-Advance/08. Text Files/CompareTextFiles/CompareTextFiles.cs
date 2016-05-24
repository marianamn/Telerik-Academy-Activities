/*Problem 4. Compare text files
• Write a program that compares two text files line by line and prints the number of lines that are 
 the same and the number of lines that are different.
• Assume the files have equal number of lines. */

using System;
using System.Collections.Generic;
using System.IO;
class CompareTextFiles
{
    static void Main()
    {
        StreamReader file1 = new StreamReader(@"..\..\..\Txt Files\Test.txt");
        StreamReader file2 = new StreamReader(@"..\..\..\Txt Files\Test2.txt");

        using (file1)
        {
            using (file2)
            {
                string linesFile1 = file1.ReadLine();
                string linesFile2 = file2.ReadLine();

                int count = 1;
                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();

                while (linesFile1 != null)
                {
                    if (linesFile1.Equals(linesFile2))
                    {
                        sameLines.Add(count);
                    }
                    else
                    {
                        differentLines.Add(count);
                    }

                    count++;
                    linesFile1 = file1.ReadLine();
                    linesFile2 = file2.ReadLine();
                }

                Console.WriteLine("Same lines: {0}", string.Join(" ", sameLines));
                Console.WriteLine("Different lines: {0}", string.Join(" ", differentLines));
            }
        }
    }
}
