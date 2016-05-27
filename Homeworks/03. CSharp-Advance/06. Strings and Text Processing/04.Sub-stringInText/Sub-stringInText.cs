namespace _04.Sub_stringInText
{
    using System;

    public class Sub_stringInText
    {
        public static void Main()
        {
            string searchText = Console.ReadLine();
            string text = Console.ReadLine();

            //text = text.ToLower();
            //searchText = searchText.ToLower();

            int count = 0;

            for (int i = 0; i < text.Length - searchText.Length +1; i++)
            {
                if (text.Substring(i, searchText.Length).Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}