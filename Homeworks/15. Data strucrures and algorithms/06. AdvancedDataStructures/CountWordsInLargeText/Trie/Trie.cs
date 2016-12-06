using System;
using System.Collections.Generic;
using System.Text;

namespace CountWordsInLargeText.Trie
{
    internal class Trie : ITrie
    {
        internal Trie(TrieNode rootTrieNode)
        {
            this.RootTrieNode = rootTrieNode;
        }

        private TrieNode RootTrieNode { get; set; }

        public void AddWord(string word)
        {
            this.AddWord(this.RootTrieNode, word.ToCharArray());
        }

        public void RemoveWord(string word)
        {
            var trieNode = this.GetTrieNode(word);
            if (trieNode == null || !trieNode.IsWord)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} does not exist in trie.", word));
            }

            trieNode.RemoveNode(this.RootTrieNode);
        }

        public ICollection<string> GetWords()
        {
            var words = new List<string>();
            var buffer = new StringBuilder();
            this.GetWords(this.RootTrieNode, words, buffer);
            return words;
        }

        public ICollection<string> GetWords(string prefix)
        {
            ICollection<string> words;
            if (string.IsNullOrEmpty(prefix))
            {
                words = this.GetWords();
            }
            else
            {
                var trieNode = this.GetTrieNode(prefix);

                // Empty list if no prefix match
                words = new List<string>();
                if (trieNode != null)
                {
                    var buffer = new StringBuilder();
                    buffer.Append(prefix);
                    this.GetWords(trieNode, words, buffer);
                }
            }

            return words;
        }

        public bool HasWord(string word)
        {
            var trieNode = this.GetTrieNode(word);
            return trieNode != null && trieNode.IsWord;
        }

        public int WordCount(string word)
        {
            var trieNode = this.GetTrieNode(word);
            return trieNode == null ? 0 : trieNode.WordCount;
        }

        public ICollection<string> GetLongestWords()
        {
            var longestWords = new List<string>();
            var buffer = new StringBuilder();
            var length = 0;
            this.GetLongestWords(this.RootTrieNode, longestWords, buffer, ref length);
            return longestWords;
        }

        public void Clear()
        {
            this.RootTrieNode.Clear();
        }

        private TrieNode GetTrieNode(string prefix)
        {
            var trieNode = this.RootTrieNode;
            foreach (var prefixChar in prefix)
            {
                trieNode = trieNode.GetChild(prefixChar);
                if (trieNode == null)
                {
                    break;
                }
            }

            return trieNode;
        }

        private void AddWord(TrieNode trieNode, char[] word)
        {
            if (word.Length == 0)
            {
                trieNode.WordCount++;
                return;
            }

            var c = Utilities.FirstChar(word);
            TrieNode child = trieNode.GetChild(c);

            if (child == null)
            {
                child = TrieFactory.CreateTrieNode(c, trieNode);
                trieNode.SetChild(child);
            }

            var childRemoved = Utilities.FirstCharRemoved(word);
            this.AddWord(child, childRemoved);
        }

        private void GetWords(TrieNode trieNode, ICollection<string> words, StringBuilder buffer)
        {
            if (trieNode.IsWord)
            {
                words.Add(buffer.ToString());
            }

            foreach (var child in trieNode.GetChildren())
            {
                buffer.Append(child.Character);
                this.GetWords(child, words, buffer);

                // Remove recent character
                buffer.Length--;
            }
        }

        private void GetLongestWords(TrieNode trieNode, ICollection<string> longestWords, StringBuilder buffer, ref int length)
        {
            if (trieNode.IsWord)
            {
                if (buffer.Length > length)
                {
                    longestWords.Clear();
                    length = buffer.Length;
                }

                if (buffer.Length >= length)
                {
                    longestWords.Add(buffer.ToString());
                }
            }

            foreach (var child in trieNode.GetChildren())
            {
                buffer.Append(child.Character);
                this.GetLongestWords(child, longestWords, buffer, ref length);

                // Remove recent character
                buffer.Length--;
            }
        }
    }
}
