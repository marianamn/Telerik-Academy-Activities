/*Problem 9. Sorting array
• Write a method that return the maximal element in a portion of array of integers 
  starting at given index.
• Using it write another method that sorts an array in ascending / descending order. */


/*Example for check 
input   array                     2, 1, 4, 7, 5, 6, 1, 5, 9
        startIndex                1
        subsequence               1, 4, 7, 5, 6, 1, 5, 9, 3    

output  max in subsequence        9
        ascending subsequence     1, 1, 3, 4, 5, 5, 6, 7, 9   
        descending subsequence    9, 7, 6, 5, 5, 4, 3, 1, 1            */

using System;
class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter number sequence, separated by comma and space:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] {' ', ',' }, System.StringSplitOptions.RemoveEmptyEntries);

        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }


        Console.WriteLine("Enter position in array: ");
        int startPosition = int.Parse(Console.ReadLine());


        Console.WriteLine("Subsequence starting from position {0} is:", startPosition);
        PrintSequence(startPosition, array);
        Console.WriteLine();
        Console.WriteLine("Max value in subsequence: {0}", MaxElementInArray(array, startPosition, array.Length));
        Console.WriteLine();
        Console.WriteLine("Subsequence sorted ascending:");
        SortAscending(startPosition, array);
        PrintSequence(startPosition, array);
        Console.WriteLine("Subsequence sorted descending:");
        SortDescending(startPosition, array);
        PrintSequence(startPosition, array);

    }

    static void PrintSequence(int position, int[] array)
    {
        for (int i = position; i < array.Length; i++)
        {
            if (position == array.Length - 2)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();

    }

    static int MaxElementInArray(int[] array, int startPosition, int endPosition)
    {
        int max = 0;
        int current = 0;
        for (int i = startPosition; i < endPosition; i++)
        {
            if (array[i] > current)
            {
                current = array[i];
            }
            else
            {
                current = 0;
                continue;
            }

            if (current > max)
            {
                max = current;
            }
        }
        return max;
    }


    static int[] SortAscending (int startindex, int[] array)
    {
        
        int[] sortedArray = array;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int max = MaxElementInArray(array, startindex, array.Length - i);
            int maxIndex = Array.IndexOf(array, max);
            int tempValue = sortedArray[maxIndex];
            sortedArray[maxIndex] = sortedArray[i];
            sortedArray[i] = tempValue;
        }
        return sortedArray;
    }

    static int[] SortDescending(int startindex, int[] array)
    {

        int[] sortedArray = array;
        for (int i = 0; i < array.Length; i++)
        {
            int max = MaxElementInArray(array, startindex, array.Length - i);
            int maxIndex = Array.IndexOf(array, max);
            int tempValue = sortedArray[maxIndex];
            sortedArray[maxIndex] = sortedArray[i];
            sortedArray[i] = tempValue;
        }
        return sortedArray;
    }



}