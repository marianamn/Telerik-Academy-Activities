namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(text[0]);
                }
                else if (text[i - 1] != text[i])
                {
                    result.Append(text[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
