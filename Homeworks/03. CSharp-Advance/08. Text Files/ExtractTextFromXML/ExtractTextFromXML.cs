/*Problem 10. Extract text from XML
• Write a program that extracts from given XML file all the text without the tags.

Example:
 <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student> */

using System;
using System.IO;
using System.Text;
class ExtractTextFromXML
{
    static void Main(string[] args)
    {
        //The File is located in folder --> \Txt files
        StreamReader file = new StreamReader(@"..\..\..\Txt Files\HTML text.txt");


        using (file)
        {

            string line = file.ReadLine(); 
             string extract = string.Empty; 
             while (line != null) 
             { 
                 for (int i = 1; i < line.Length; i++) 
                 { 
                     if (line[i - 1] == '>') 
                     { 
                         while (line[i] != '<') 
                         { 
                             extract += line[i]; 
                             i++; 
                         } 
                         if (extract != "") 
                         { 
                             Console.WriteLine(extract.TrimStart(' ')); 
                             extract = ""; 
                        } 
                     } 
                 }
                 line = file.ReadLine(); 
             } 
         } 
     } 
 } 
