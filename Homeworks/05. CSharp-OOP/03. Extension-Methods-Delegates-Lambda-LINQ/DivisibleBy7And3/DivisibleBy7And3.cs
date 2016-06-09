/*Problem 6. Divisible by 7 and 3
 • Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
   Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ. */

using System;
using System.Collections.Generic;
using System.Linq;


namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] array = new int[] {3, 15, 21, 27, 42, 63, 100};

            Console.WriteLine("Initial array of integers:");
            Print(array);

            Console.WriteLine("Numbers devisible by 7 and 3 using lambda expressions:");
            var result = array.Where(x => x % 3 == 0 && x % 7 == 0);
            Print(result);

            Console.WriteLine("Numbers devisible by 7 and 3 using LINQ:");
            var result1 = (from number in array
                           where number% 3 == 0 && number % 7 == 0
                           select number);
            Print(result1);
        }

        public static void Print<T>(IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
