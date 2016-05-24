/*Problem 12. Remove words
• Write a program that removes from a text file all words listed in given another text file.
• Handle all possible exceptions in your methods. */

using System; 
using System.IO; 
using System.Linq; 
using System.Text; 
using System.Text.RegularExpressions;


class RemoveWords
 { 
     static void Main() 
     {
         try
         {
             //files are in folder -->Txt files
             string allLines = String.Join(" ", File.ReadAllLines(@"..\..\..\Txt Files\Words List.txt"));
             string[] allWords = allLines.Split(' ');
             using (StreamReader start = new StreamReader(@"..\..\..\Txt Files\Deleeting words.txt"))
             {
                 string line = start.ReadLine();
                 using (StreamWriter finish = new StreamWriter(@"..\..\..\Txt Files\Deleeting words Output.txt"))
                 {
                     while (line != null)
                     {
                         for (int i = 0; i < allWords.Length; i++)
                         {
                             string word = "\\b" + allWords[i] + "\\b";
                             line = Regex.Replace(line, word, "");
                         }
                         finish.WriteLine(line);
                         line = start.ReadLine();

                     }
                 }
             }
         }


         catch (Exception e)
         {
             Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
         } 
         Console.WriteLine("Words has been deleted.");
    } 
 } 
 
