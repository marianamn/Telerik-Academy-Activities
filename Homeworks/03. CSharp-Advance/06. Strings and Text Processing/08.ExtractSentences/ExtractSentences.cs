namespace _08.ExtractSentences
{
    using System;
    using System.Collections.Generic;

    public class ExtractSentences
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            string[] text = Console.ReadLine().Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> sentences = new List<string>();
            char[] signs = { '.', '!', '?' };

            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Trim().Split(new char[] { ',', ' ', ':', '-', '(', ')', '/', '*', '\'', ';', '\n', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < words.Length; j++)
                {
                    if (word.Equals(words[j], StringComparison.InvariantCultureIgnoreCase))
                    {
                        sentences.Add(text[i]);
                        sentences.Add(".");
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("", sentences));
        }
    }
}
