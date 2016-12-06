namespace CountWordsInLargeText.Trie
{
    internal static class Utilities
    {
        public static char[] FirstCharRemoved(char[] word)
        {
            char[] charRemoved = null;
            if (word.Length > 0)
            {
                charRemoved = new char[word.Length - 1];
                for (var i = 1; i < word.Length; i++)
                {
                    charRemoved[i - 1] = word[i];
                }
            }

            return charRemoved;
        }

        public static char FirstChar(char[] word)
        {
            return word[0];
        }
    }
}
