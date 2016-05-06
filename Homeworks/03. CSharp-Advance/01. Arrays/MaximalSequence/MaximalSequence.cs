/*Problem 4. Maximal sequence
• Write a program that finds the maximal sequence of equal elements in an array.
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Print the length of the maximal sequence

Example:
input                               result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1        3  (2, 2, 2)*/

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
        int maxCount = 1;

        for (int i = 0; i < n-1; i++)
        {
            if (array[i] == array[i+1])
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

        Console.WriteLine(maxCount);
    }
}

///more UI specified solution
//using System;
//class MaximalSequence
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter number sequence, separated by commas:");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
//
//
//        int currentLength = 1;
//        string currentElement = numbers[0];
//        int maxLenght = 0;
//        string maxElement = "";
//
//
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (numbers[i] == currentElement)
//            {
//                currentLength++;
//            }
//            else
//            {
//                currentElement = numbers[i];
//                currentLength = 1;
//            }
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
//        }
//
//        for (int i = 0; i < maxLenght; i++)
//        {
//            if (i < (maxLenght - 1))
//            {
//                Console.Write("{0}, ", maxElement);
//            }
//            else
//            {
//                Console.Write(maxElement);
//            }
//        }
//
//        Console.WriteLine();
//    }
//}

