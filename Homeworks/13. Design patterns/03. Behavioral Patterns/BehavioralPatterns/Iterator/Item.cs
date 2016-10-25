namespace Iterator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A collection item
    /// </summary>
    public class Item
    {
        private string name;

        public Item(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
