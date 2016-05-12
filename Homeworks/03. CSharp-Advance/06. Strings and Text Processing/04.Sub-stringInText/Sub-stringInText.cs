namespace _04.Sub_stringInText
{
    using System;

    public class Sub_stringInText
    {
        public static void Main()
        {
            string searchText = Console.ReadLine();
            string input = Console.ReadLine();

            string text = input.ToLower();
            int count = 0;

            for (int i = 0; i < text.Length - searchText.Length; i++)
            {
                if (text.Substring(i, searchText.Length) == searchText)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
