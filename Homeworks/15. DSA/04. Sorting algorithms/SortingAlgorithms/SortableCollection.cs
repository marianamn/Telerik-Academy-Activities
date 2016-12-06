using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int start = 0;
            int end = this.items.Count;
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;

                // the element we search is located to the right from the mid point
                if (this.items[mid].CompareTo(item) == -1)
                {
                    start = mid + 1;
                    continue;
                }
                else if (this.items[mid].CompareTo(item) == 1)
                {
                    // the element we search is located to the left from the mid point
                    end = mid - 1;
                    continue;
                }
                else
                {
                    // at this point low and high bound are equal and we have found the element or
                    // collection[mid] is just equal to the value => we have found the searched element
                    return true;
                }
            }

            // value not found
            return false;
        }

        public void Shuffle()
        {
            var random = new Random();
            int n = this.Items.Count;

            for (int i = 0; i < n; i++)
            {
                var j = random.Next(i, this.items.Count);
                this.Swap(i, j, this.items);
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private void Swap(int start, int end, IList<T> collection)
        {
            var buffer = collection[start];
            collection[start] = collection[end];
            collection[end] = buffer;
        }
    }
}
