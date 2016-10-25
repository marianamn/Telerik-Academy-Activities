namespace Iterator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
