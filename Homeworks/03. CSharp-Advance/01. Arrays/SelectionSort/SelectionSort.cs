/*Problem 7. Selection sort
• Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
• Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
  find the smallest from the rest, move it at the second position, etc. */


using System;
class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array [min])
                {
                    min = j;
                }
            }

            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

///more UI specified solution

//using System;
//class SelectionSort
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter array lenght n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//
//        Console.WriteLine("Enter array:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("array[{0}] = ", i);
//            array[i] = int.Parse(Console.ReadLine());
//        }
//
//        for (int i = 0; i < n - 1; i++)
//        {
//            int min = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (array[j] < array[min])
//                {
//                    min = j;
//                }
//            }
//            int temp = array[i];
//            array[i] = array[min];
//            array[min] = temp;
//        }
//
//        Console.WriteLine("Sorted array:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("array[{0}] = {1}", i, array[i]);
//        }
//    }
//}