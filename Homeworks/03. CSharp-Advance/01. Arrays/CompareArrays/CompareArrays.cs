/*Problem 2. Compare arrays
• Write a program that reads two  integer  arrays from the console and compares them element by element.*/

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        int[] secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (firstArray.SequenceEqual(secondArray))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}


///more UI specified solution

//using System;
//class CompareArrays
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter first array lenght: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] firstArray = new int[n];
//
//
//        Console.WriteLine("Enter second array lenght: ");
//        int m = int.Parse(Console.ReadLine());
//        int[] secondArray = new int[m];
//
//        Console.WriteLine("Enter first int array: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("first array[{0}] = ", i);
//            firstArray[i] = int.Parse(Console.ReadLine());
//        }
//
//
//        Console.WriteLine("Enter second int array: ");
//        for (int i = 0; i < m; i++)
//        {
//            Console.Write("first array[{0}] = ", i);
//            secondArray[i] = int.Parse(Console.ReadLine());
//        }
//
//        if (n != m)
//        {
//            Console.WriteLine("First array is not equal to second array.");
//        }
//        else
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (firstArray[i] == secondArray[i])
//                {
//                    Console.WriteLine("first array [{0}] is equal to second array [{0}]", i);
//                }
//                else
//                {
//                    Console.WriteLine("first array [{0}] is not equal to second array [{0}]", i);
//                }
//            }
//        }
//    }
//}