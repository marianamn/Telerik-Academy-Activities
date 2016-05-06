/*Problem 14. Quick sort
• Write a program that sorts an array of integers using the Quick sort algorithm.*/


//Some Examples
//input      6, 5, 3, 1, 8, 7, 2, 9, 4
//input      12, 1, 3, 5, 8, 10, 2, 9, 4


using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Quicksort(array, 0, array.Length - 1);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}


///more UI specified solution
///
//using System;
//
//class QuickSort
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter number sequence, separated by commas:");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//
//        int[] arr = new int[numbers.Length];
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            arr[i] = int.Parse(numbers[i]);
//        }
//
//
//        Quicksort(arr, 0, arr.Length - 1);
//        Console.WriteLine("Sorted array:\n{0}", string.Join(", ", arr));
//
//    }
//
//    public static void Quicksort(int[] elements, int left, int right)
//    {
//        int i = left, j = right;
//        int pivot = elements[(left + right) / 2];
//
//        while (i <= j)
//        {
//            while (elements[i].CompareTo(pivot) < 0)
//            {
//                i++;
//            }
//
//            while (elements[j].CompareTo(pivot) > 0)
//            {
//                j--;
//            }
//
//            if (i <= j)
//            {
//                int tmp = elements[i];
//                elements[i] = elements[j];
//                elements[j] = tmp;
//
//                i++;
//                j--;
//            }
//        }
//
//
//        if (left < j)
//        {
//            Quicksort(elements, left, j);
//        }
//
//        if (i < right)
//        {
//            Quicksort(elements, i, right);
//        }
//    }
//}

