/*Problem 9. Frequent number
• Write a program that finds the most frequent number in an array.

Example:
input                                          result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3          4 (5 times)  */


using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int currentCount = 1;
        int maxCount = 1;
        int currentElement = 0;
        int maxElement = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i+1])
            {
                currentCount++;
                currentElement = array[i];
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = currentElement;
            }
        }

        Console.WriteLine("{0} ({1} times)", maxElement, maxCount);
    }
}


///more UI specified solution
///
//using System;
//
//class FrequentNumber
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
//        int maxNum = 0;
//        int currentNum = 0;
//        int count = 1;
//        int countMax = 1;
//        Array.Sort(array);
//
//
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] == array[i + 1])
//            {
//                count++;
//                currentNum = array[i];
//            }
//            else
//            {
//                currentNum = array[i];
//                count = 1;
//            }
//
//            if (count >= countMax)
//            {
//                countMax = count;
//                maxNum = currentNum;
//            }
//
//        }
//        Console.WriteLine("Most frequent number: {0} ({1} times)", maxNum, countMax);
//
//    }
//}

