using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
            dictionary.Add("homework", "series of no less than 25 problems");


            Console.Write("Search for a word from the dictionary: ");
            string word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("{0} - {1}", word, dictionary[word]);
            }
            else
            {
                Console.WriteLine("{0} not found in the dictionary", word);
            }
        }
    }
}
