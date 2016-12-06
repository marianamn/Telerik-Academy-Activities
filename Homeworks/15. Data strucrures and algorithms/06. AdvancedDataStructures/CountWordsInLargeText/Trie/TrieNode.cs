using System.Collections.Generic;

namespace CountWordsInLargeText.Trie
{
    internal class TrieNode
    {
        internal TrieNode(char character, IDictionary<char, TrieNode> children, int wordCount, TrieNode parent)
        {
            this.Character = character;
            this.Children = children;
            this.WordCount = wordCount;
            this.Parent = parent;
        }

        internal char Character { get; private set; }

        internal IDictionary<char, TrieNode> Children { get; set; }

        internal bool IsWord
        {
            get { return this.WordCount > 0; }
        }

        internal int WordCount { get; set; }

        internal TrieNode Parent { get; private set; }

        public override string ToString()
        {
            return this.Character.ToString();
        }

        public override bool Equals(object obj)
        {
            TrieNode that;
            return
                obj != null
                && (that = obj as TrieNode) != null
                && that.Character == this.Character;
        }

        public override int GetHashCode()
        {
            return this.Character.GetHashCode();
        }

        internal IEnumerable<TrieNode> GetChildren()
        {
            return this.Children.Values;
        }

        internal TrieNode GetChild(char character)
        {
            TrieNode trieNode;
            this.Children.TryGetValue(character, out trieNode);
            return trieNode;
        }

        internal void SetChild(TrieNode child)
        {
            this.Children[child.Character] = child;
        }

        internal void RemoveNode(TrieNode rootTrieNode)
        {
            // set this node's word count to 0
            this.WordCount = 0;
            this.RemoveNode_Recursive(rootTrieNode);
        }

        internal void Clear()
        {
            this.WordCount = 0;
            this.Children.Clear();
        }

        private void RemoveChild(char character)
        {
            this.Children.Remove(character);
        }

        private void RemoveNode_Recursive(TrieNode rootTrieNode)
        {
            if (this.Children.Count == 0 && !this.IsWord && this != rootTrieNode)
            {
                var parent = this.Parent;
                this.Parent.RemoveChild(this.Character);
                this.Parent = null;
                parent.RemoveNode_Recursive(rootTrieNode);
            }
        }
    }
}