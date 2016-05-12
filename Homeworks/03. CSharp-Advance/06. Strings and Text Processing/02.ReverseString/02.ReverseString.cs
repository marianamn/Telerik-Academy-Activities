namespace _02.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string reversedText = new string(text.Reverse().ToArray());

            Console.WriteLine(Convert.ToString(reversedText));
        }
    }
}
