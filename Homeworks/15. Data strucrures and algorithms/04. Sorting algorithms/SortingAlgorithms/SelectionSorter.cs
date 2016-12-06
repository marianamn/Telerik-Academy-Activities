using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int j = 0; j < collection.Count - 1; j++)
            {
                var minKey = j;

                for (int k = j + 1; k < collection.Count; k++)
                {
                    if (collection[k].CompareTo(collection[minKey]) == -1)
                    {
                        minKey = k;
                    }
                }

                this.Swap(minKey, j, collection);
            }
        }

        private void Swap(int start, int end, IList<T> collection)
        {
            var buffer = collection[start];
            collection[start] = collection[end];
            collection[end] = buffer;
        }
    }
}
