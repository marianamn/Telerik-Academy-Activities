using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.MergeSort(collection, 0, collection.Count - 1);
        }

        private void MergeSort(IList<T> collection, int start, int end)
        {
            if (start < end)
            {
                var middle = (start + end) / 2;
                this.MergeSort(collection, start, middle);
                this.MergeSort(collection, middle + 1, end);

                // merging
                var currentPositon = start;
                var secondCollectionPosition = middle + 1;
                while (currentPositon <= middle)
                {
                    if (collection[currentPositon].CompareTo(collection[secondCollectionPosition]) > 0)
                    {
                        this.Swap(currentPositon, secondCollectionPosition, collection);

                        // keep second part sorted
                        while (secondCollectionPosition < end && collection[secondCollectionPosition].CompareTo(collection[secondCollectionPosition + 1]) > 0)
                        {
                            this.Swap(secondCollectionPosition, secondCollectionPosition + 1, collection);
                            ++secondCollectionPosition;
                        }

                        secondCollectionPosition = middle + 1;
                    }
                    ++currentPositon;
                }

                while (currentPositon < end && collection[currentPositon].CompareTo(collection[currentPositon + 1]) > 0)
                {
                    this.Swap(currentPositon, currentPositon + 1, collection);
                    ++currentPositon;
                }
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