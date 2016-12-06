// Write a program that finds a set of words(e.g. 1000 words) in a large text(e.g. 100 MB text file).
// Print how many times each word occurs in the text.
// Hint: you may find a C# trie in Internet.

using System;
using System.Collections.Generic;
using System.IO;
using CountWordsInLargeText.Trie;

namespace CountWordsInLargeText
{
    public class Startup
    {
        public static void Main()
        {
            string[] words = ReadWordsFromFile();

            ITrie trie = TrieFactory.CreateTrie();
            Dictionary<string, int> wordsOccurence = new Dictionary<string, int>();

            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            foreach (var word in words)
            {
                var count = trie.WordCount(word);
                Console.WriteLine("{0} --> {1}", word, count);
            }             
        }

        private static string[] ReadWordsFromFile()
        {
            StreamReader file = new StreamReader(@"..\..\text.txt");

            // uncomment to test bigget file
            // StreamReader file = new StreamReader(@"..\..\text1.txt");
            string text = string.Empty;

            using (file)
            {
                text = file.ReadToEnd().ToLower();
            }

            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "–" };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}