/*Problem 2. IEnumerable extensions
 • Implement a set of extension methods for  IEnumerable<T>  that implement the following group 
  functions: sum, product, min, max, average. */

using System;
using System.Collections.Generic;

namespace IEnumerableExtensions
{
    public class IEnumerableExtensionsMain
    {
        public static void Main()
        {
            List<int> testList = new List<int> { 2, 3, 4, 5, 6};

            Console.WriteLine("Sum = {0}", IEnumerableExtensions.SumOfCollection(testList));
            Console.WriteLine("Prod = {0}", IEnumerableExtensions.ProductOfCollection(testList));
            Console.WriteLine("Min = {0}", IEnumerableExtensions.MinOfCollection(testList));
            Console.WriteLine("Max = {0}", IEnumerableExtensions.MaxOfCollection(testList));
            Console.WriteLine("Avrg = {0:F2}", IEnumerableExtensions.AvrgOfCollection(testList));
        }
    }
}
