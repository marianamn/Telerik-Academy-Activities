/*Problem 13.* Merge sort
• Write a program that sorts an array of integers using the Merge sort algorithm. */

//Some Examples
//input      6, 5, 3, 1, 8, 7, 2, 9, 4
//input      12, 1, 3, 5, 8, 10, 2, 9, 4


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        array = MergeSort(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    private static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < middle)
            {
                left[i] = array[i];
            }
            else
            {
                right[i - middle] = array[i];
            }
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }
    
    private static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length;)
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }

        for (; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }

        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }

        return result;
    }
}


///more UI specified solution
///
//using System; 
//
// class Program
//{
//    static void Main()
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
//        arr = MergeSort(arr);
//        Console.WriteLine("Sorted array:\n{0}", string.Join(", ", arr));
//    }
//
//
//    private static int[] MergeSort(int[] arr)
//    {
//        if (arr.Length <= 1)
//        {
//            return arr;
//        }
//
//
//        int middle = arr.Length / 2;
//        int[] left = new int[middle];
//        int[] right = new int[arr.Length - middle];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (i < middle)
//            {
//                left[i] = arr[i];
//            }
//            else
//            {
//                right[i - middle] = arr[i];
//            }
//        }
//
//        left = MergeSort(left);
//        right = MergeSort(right);
//
//        return Merge(left, right);
//    }
//
//
//    private static int[] Merge(int[] left, int[] right)
//    {
//        int[] result = new int[left.Length + right.Length];
//        int i, j;
//        for (i = 0, j = 0; i < left.Length && j < right.Length;)
//        {
//            if (left[i] < right[j])
//            {
//                result[i + j] = left[i];
//                i++;
//            }
//            else
//            {
//                result[i + j] = right[j];
//                j++;
//            }
//        }
//
//        for (; i < left.Length; i++)
//        {
//            result[i + j] = left[i];
//        }
//
//        for (; j < right.Length; j++)
//        {
//            result[i + j] = right[j];
//        }
//
//        return result;
//    }
//}
