using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            char sign = sentence[sentence.Length - 1];
            sentence = sentence.Remove(sentence.Length - 1, 1);
            string[] words = sentence.Split(' ');

            // get all punctuationList positions and remove from words 
            List<int> punctuation = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(","))
                {
                    punctuation.Add(i);
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }

            Array.Reverse(words);

            // insert punctuation at original positions into reversed array 
            if (punctuation.Count > 0)
            {
                for (int i = 0; i < punctuation.Count; i++)
                {
                    words[punctuation[i]] += ',';
                }
            }


            string reversedSentence = String.Join(" ", words) + sign;
            Console.WriteLine(reversedSentence);
        }
    }
}
