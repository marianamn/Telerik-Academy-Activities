/*Problem 10. Find sum in array
 • Write a program that finds in given array of integers a sequence of given sum  S  (if present).

Example:
array                    S     result
4, 3, 1, 4, 2, 5, 8      11    4, 2, 5    */

using System;
class FindSumInArray
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        int sum = int.Parse(Console.ReadLine());

        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum > sum)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += array[i];

            if (currentSum == sum)
            {
                endIndex = i;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }

        Console.WriteLine();
    }
}


///more UI specified solution
///
//using System;
//class FindSumInArray
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
//        Console.WriteLine("Enter number s:");
//        int s = int.Parse(Console.ReadLine());
//
//
//        int currSum = 0;
//        int startIndex = 0;
//
//
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            currSum += array[i];
//            startIndex = i;
//            for (int j = i + 1; j < array.Length; j++)
//            {
//                currSum += array[j];
//                if (currSum == s)
//                {
//                    for (int k = startIndex; k <= j; k++)
//                    {
//                        if (k == j)
//                        {
//                            Console.Write(array[k]);
//                        }
//                        else
//                        {
//                            Console.Write("{0}, ", array[k]);
//                        }
//                    }
//                    break;
//                }
//            }
//            currSum = 0;
//        }
//
//
//        Console.WriteLine();
//    }
//}

