using System;

namespace _04.CompareSortAlgorithms
{
    internal class SortAlgorithms
    {
        internal static void SelectionSort<T>(T[] collection)
            where T : IComparable
        {
            for (var i = 0; i < collection.Length - 1; i++)
            {
                var minInd = i;

                for (var j = i + 1; j < collection.Length; j++)
                {
                    if (collection[i].CompareTo(collection[j]) > 0)
                    {
                        minInd = j;
                    }
                }

                if (minInd != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[minInd];
                    collection[minInd] = temp;
                }
            }
        }

        internal static void Quicksort<T>(T[] collection, int left, int right)
            where T : IComparable
        {
            int i = left;
            int j = right;
            T pivot = collection[(left + right) / 2];

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
                    T previousValue = collection[i];
                    collection[i] = collection[j];
                    collection[j] = previousValue;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(collection, left, j);
            }

            if (i < right)
            {
                Quicksort(collection, i, right);
            }
        }

        internal static void InsertionSort<T>(T[] collection) 
            where T : IComparable
        {
            for (var i = 0; i < collection.Length - 1; i++)
            {
                var index = i + 1;

                while (index > 0)
                {
                    if (collection[index - 1].CompareTo(collection[index]) > 0)
                    {
                        var temp = collection[index - 1];
                        collection[index - 1] = collection[index];
                        collection[index] = temp;
                    }

                    index--;
                }
            }
        }
    }
}
