namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Test with int collection:");
            List<int> testList = new List<int> { 2, 3, 4, 5, 6 };
            Console.WriteLine("Sum = {0}", IEnumerableExtensions.SumOfCollection(testList));
            Console.WriteLine("Prod = {0}", IEnumerableExtensions.ProductOfCollection(testList));
            Console.WriteLine("Min = {0}", IEnumerableExtensions.MinOfCollection(testList));
            Console.WriteLine("Max = {0}", IEnumerableExtensions.MaxOfCollection(testList));
            Console.WriteLine("Avrg = {0:F2}", IEnumerableExtensions.AvrgOfCollection(testList));

            Console.WriteLine("Test with double collection:");
            List<double> testList2 = new List<double> { 2.5, 3.6, 4, 5.8, 6 };
            Console.WriteLine("Sum = {0}", IEnumerableExtensions.SumOfCollection(testList2));
            Console.WriteLine("Prod = {0}", IEnumerableExtensions.ProductOfCollection(testList2));
            Console.WriteLine("Min = {0}", IEnumerableExtensions.MinOfCollection(testList2));
            Console.WriteLine("Max = {0}", IEnumerableExtensions.MaxOfCollection(testList2));
            Console.WriteLine("Avrg = {0:F2}", IEnumerableExtensions.AvrgOfCollection(testList2));
        }
    }
}
