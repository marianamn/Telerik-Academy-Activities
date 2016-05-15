namespace _08.ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractSentences
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            List<string> sentences = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Trim().Split(new char[] { ',', ' ', ':', '-', '(', ')', '/', '*'}, StringSplitOptions.RemoveEmptyEntries);

                if (words.Contains(word))
                {
                    sentences.Add(text[i]);
                    // TODO: if the sentence end is not a dot?
                    sentences.Add(".");
                }
            }

            Console.WriteLine(string.Join("", sentences));
        }
    }
}
