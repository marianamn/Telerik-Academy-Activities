namespace _01.StringBuilderExtention
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            StringBuilder someText = new StringBuilder("Some text for testing.");
            Console.WriteLine(someText.Substring(0, 10));
        }
    }
}
