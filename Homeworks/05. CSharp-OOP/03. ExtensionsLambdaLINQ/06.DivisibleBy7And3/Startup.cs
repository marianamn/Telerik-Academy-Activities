namespace _06.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] array = new int[] { 3, 15, 21, 27, 42, 63, 100 };

            Console.WriteLine("Initial array of integers:");
            Print(array);

            Console.WriteLine("Numbers devisible by 7 and 3 using lambda expressions:");
            var result = array.Where(x => x % 3 == 0 && x % 7 == 0);
            Print(result);

            Console.WriteLine("Numbers devisible by 7 and 3 using LINQ:");
            var result1 = from number in array
                          where number % 3 == 0 && number % 7 == 0
                          select number;
            Print(result1);
        }

        public static void Print<T>(IEnumerable<T> array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}