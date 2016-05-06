/*Problem 8. Maximal sum
 • Write a program that finds the sequence of maximal sum in given array.

Example:
input                                   result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8        11 ---> 2, -1, 6, 4 
• Can you do it with only one loop (with single scan through the elements of the array)? */

using System;
class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = array[0];
        int maxSum = array[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += array[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
            }
        }

        Console.WriteLine(maxSum);

        //for (int i = startIndex; i <= endIndex; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}
    }
}

///more UI specified solution
///
//using System;
//class MaximalSum
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter number sequence, separated by commas:");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//
//        //transferring string numbers into int
//        int[] array = new int[numbers.Length];
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            array[i] = int.Parse(numbers[i]);
//        }
//
//        int currSum = array[0];
//        int startIndex = 0;
//        int endIndex = 0;
//        int tempIndex = 0;
//        int maxSum = array[0];
//
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (currSum <= 0)
//            {
//                startIndex = i;
//                currSum = 0;
//            }
//            currSum += array[i];
//
//            if (currSum > maxSum)
//            {
//                maxSum = currSum;
//                tempIndex = startIndex;
//                endIndex = i;
//            }
//        }
//
//        Console.WriteLine("The max sum sequance is: ");
//        for (int i = startIndex; i <= endIndex; i++)
//        {
//            if (i == endIndex)
//            {
//                Console.Write(array[i]);
//            }
//            else
//            {
//                Console.Write("{0}, ", array[i]);
//            }
//        }
//        Console.WriteLine();
//    }
//}