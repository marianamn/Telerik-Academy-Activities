namespace Iterator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IAbstractIterator
    {
        bool IsDone { get; }

        Item CurrentItem { get; }

        Item First();

        Item Next();
    }
}
