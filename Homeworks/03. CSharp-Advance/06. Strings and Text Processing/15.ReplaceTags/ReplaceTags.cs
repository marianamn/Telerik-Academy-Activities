namespace _15.ReplaceTags
{
    using System;

    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            text = text.Replace(@"<a href=""", "[URL=");
            text = text.Replace(@""">", "]");
            text = text.Replace("</a>", "[/URL]");

            Console.WriteLine(text);
        }
    }
}
