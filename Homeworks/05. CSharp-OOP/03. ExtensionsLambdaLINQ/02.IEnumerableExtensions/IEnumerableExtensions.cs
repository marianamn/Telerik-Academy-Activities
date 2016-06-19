namespace _02.IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOfCollection<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)1;
            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinOfCollection<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T MaxOfCollection<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        public static double AvrgOfCollection<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum / (dynamic)collection.Count();
        }
    }
}
