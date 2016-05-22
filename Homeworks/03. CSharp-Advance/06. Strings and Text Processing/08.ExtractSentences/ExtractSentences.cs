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
            string inputText = Console.ReadLine();

            string[] text = inputText.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = ExtractNonLetterSeparators(inputText);

            List<string> sentences = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Trim().Split(separators);

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

        static char[] ExtractNonLetterSeparators(string input)
        {
            char[] separators = input.Where(c => !char.IsLetter(c))
                                     .Distinct()
                                     .ToArray();
            return separators;
        }
    }
}
