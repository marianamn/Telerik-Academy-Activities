namespace Memento
{
    using System;

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class ProspectMemory
    {
        private Memento memento;

        // Property
        public Memento Memento
        {
            get { return this.memento; }
            set { this.memento = value; }
        }
    }
}
