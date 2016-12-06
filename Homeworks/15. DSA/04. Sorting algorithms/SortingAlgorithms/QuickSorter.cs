using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.Quicksort(collection, 0, collection.Count - 1);
        }

        private void Quicksort(IList<T> collection, int left, int right)
        {
            int i = left, j = right;
            var pivot = collection[(left + right) / 2];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    this.Swap(i, j, collection);
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                this.Quicksort(collection, left, j);
            }

            if (i < right)
            {
                this.Quicksort(collection, i, right);
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
