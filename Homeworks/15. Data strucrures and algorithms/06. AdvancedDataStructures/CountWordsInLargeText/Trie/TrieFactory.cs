using System.Collections.Generic;

namespace CountWordsInLargeText.Trie
{
    public static class TrieFactory
    {
        public static ITrie CreateTrie()
        {
            return new Trie(CreateTrieNode(' ', null));
        }

        internal static TrieNode CreateTrieNode(char character, TrieNode parent)
        {
            return new TrieNode(
                character,
                new Dictionary<char, TrieNode>(),
                0,
                parent);
        }
    }
}
