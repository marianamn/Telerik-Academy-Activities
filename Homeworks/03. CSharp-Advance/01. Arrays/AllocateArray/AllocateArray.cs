/*Problem 1. Allocate array
• Write a program that allocates array of  20  integers and initializes each element by its index multiplied by 5.
• Print the obtained array on the console.*/

using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

///more UI specified solution

//using System;
//
//class AllocateArray
//{
//    static void Main()
//    {
//        int[] array = new int[20];
//
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = i * 5;
//        }
//
//        Console.WriteLine(string.Join(", ", array));
//    }
//}
