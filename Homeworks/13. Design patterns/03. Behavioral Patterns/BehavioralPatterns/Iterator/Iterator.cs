namespace Iterator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        private Collection collection;
        private int current = 0;
        private int step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        // Gets current iterator item
        public Item CurrentItem
        {
            get { return this.collection[this.current] as Item; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return this.current >= this.collection.Count; }
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return this.step; }
            set { this.step = value; }
        }

        // Gets first item
        public Item First()
        {
            this.current = 0;
            return this.collection[this.current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            this.current += this.step;
            if (!this.IsDone)
            {
                return this.collection[this.current] as Item;
            }
            else
            {
                return null;
            }  
        }
    }
}
