namespace _05.ParseTags
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ParseTags
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            var replacedText = Regex.Replace(text, @"<upcase>(.*?)</upcase>", m => m.ToString().ToUpper());
            replacedText = replacedText.Replace("<UPCASE>", "");
            replacedText = replacedText.Replace("</UPCASE>", "");

            Console.WriteLine(replacedText);

            
            //string openTag = "<upcase>";
            //string closeTag = "</upcase>";
            //StringBuilder result = new StringBuilder();
            //
            //for (int i = 0; i < text.Length - openTag.Length; i++)
            //{
            //    string sub = text.Substring(text.IndexOf(openTag, i) + openTag.Length, 
            //        text.IndexOf(closeTag, i) - text.IndexOf(openTag, i) - closeTag.Length).ToUpper();
            //    Console.WriteLine(sub);
            //}
            //
            //text = text.Replace(openTag, "");
            //text = text.Replace(closeTag, "");
            //
            //Console.WriteLine(text);
        }
    }
}
