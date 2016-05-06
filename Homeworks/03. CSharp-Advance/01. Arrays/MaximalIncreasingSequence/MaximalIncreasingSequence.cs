/*Problem 5. Maximal increasing sequence
 • Write a program that finds the maximal increasing sequence in an array.
 On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Example:
input                  result
3, 2, 3, 4, 2, 2, 4    3  ---> 2, 3, 4 */

using System;
public class MaximalSequence
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentCount = 1;
        int maxCount = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        Console.WriteLine(maxCount);
    }
}

///more UI specified solution
//using System;
//class MaximalSequence
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter number sequence, separated by commas:");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//
//        int currentLength = 1;
//        string currentElement = numbers[0];
//        int maxLenght = 0;
//        string maxElement = "";
//
//
//        for (int i = 1; i < numbers.Length; i++)
//        {
//            if ((Convert.ToInt32(numbers[i]) - 1) == Convert.ToInt32(currentElement))
//            {
//                currentLength++;
//                currentElement = numbers[i];
//            }
//            else
//            {
//                currentElement = numbers[i];
//                currentLength = 1;
//            }
//
//
//            if (currentLength >= maxLenght)
//            {
//                maxLenght = currentLength;
//                maxElement = currentElement;
//            }
//            else
//            {
//                continue;
//            }
//            Console.Write("{0}, ", maxElement);
//        }
//
//        Console.WriteLine();
//    }
//}
