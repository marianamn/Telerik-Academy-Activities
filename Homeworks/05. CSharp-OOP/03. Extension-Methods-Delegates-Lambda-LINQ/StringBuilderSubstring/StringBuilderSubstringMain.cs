/*Problem 1. StringBuilder.Substring
 • Implement an extension method  Substring(int index, int length)  for the class  StringBuilder  
  that returns new  StringBuilder  and has the same functionality as  Substring  in the class  String .*/


using System;
using System.Text;

namespace StringBuilderSubstring
{
    public class StringBuilderSubstringMain
    {
        public static void Main()
        {
            StringBuilder someText = new StringBuilder("Some text for testing.");
            Console.WriteLine(someText.Substring(0 , 10));

            //test with Data read from Console:

            //Console.WriteLine("Enter some text:");
            //string text = Console.ReadLine();
            //
            //Console.WriteLine("Enter substring start index:");
            //int startIndex = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine("Enter substring length:");
            //int length = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine(text.Substring(startIndex, length));
        }
    }
}
