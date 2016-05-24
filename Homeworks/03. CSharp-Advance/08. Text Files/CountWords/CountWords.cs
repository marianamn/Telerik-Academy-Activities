/*Problem 13. Count words
• Write a program that reads a list of words from the file  words.txt  and finds how many times each of
  the words is contained in another file  test.txt .
• The result should be written in the file  result.txt  and the words should be sorted by the number of 
  their occurrences in descending order.
• Handle all possible exceptions in your methods. */

using System;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            //files are in folder -->Txt files
            string[] words = File.ReadAllLines(@"..\..\..\Txt Files\words.txt");
            int[] counter = new int[words.Length];

            using (StreamReader readWords = new StreamReader(@"..\..\..\Txt Files\test words.txt"))
            {
                string line = readWords.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        counter[i] = counter[i] + Regex.Matches(line, "\\b" + words[i] + "\\b").Count;
                    }
                    line = readWords.ReadLine();
                }
            }
            Array.Sort(counter, words);


            using (StreamWriter repeatedWords = new StreamWriter(@"..\..\..\Txt Files\words count.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    repeatedWords.WriteLine("{0}: {1}", words[i], counter[i]);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
        }

        Console.WriteLine("Words have been count ad written in file words cout.txt");
    }
}
