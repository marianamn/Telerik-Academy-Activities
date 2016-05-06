/*Problem 16.* Subset with sum S
• We are given an array of integers and a number S.
• Write a program to find if there exists a subset of the elements of the array that has a sum  S.

Example:
input array                 S        result
2, 1, 2, 4, 3, 5, 2, 6      14       yes           */  

          

using System;
class SubsetWithSumS
{
    static void Main()
    {
        Console.WriteLine("Enter number sequence, separated by commas:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine("Enter sum S:");
        int s = int.Parse(Console.ReadLine());

        int currSum = 0;
        bool isSumS = false;
        Array.Sort(array);

        for (int i = 0; i < array.Length - 1; i++)
        {
            currSum += array[i];

            for (int j = i + 1; j < array.Length; j++)
            {
                if (currSum == s)
                {
                    isSumS = true;
                    break;
                }

                if (currSum > s || j == array.Length)
                {
                    currSum = currSum + array[j];
                }
            }
        }


        if (isSumS == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
