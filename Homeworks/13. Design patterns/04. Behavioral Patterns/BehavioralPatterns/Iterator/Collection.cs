namespace Iterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class Collection : IAbstractCollection
    {
        private ArrayList items = new ArrayList();

        // Gets item count
        public int Count
        {
            get { return this.items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Add(value); }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
