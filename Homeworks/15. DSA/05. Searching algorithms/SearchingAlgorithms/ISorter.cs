using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    public interface ISorter<T> where T : IComparable<T>
    {
        void Sort(IList<T> collection);
    }
}
