/*Problem 4. Appearance count
• Write a method that counts how many times given number appears in given array.
• Write a test program to check if the method is workings correctly.  */


/*Examples for check 
input                              check number           result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1            2                   5       */

using System;
using System.Linq;
class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter number sequence, separated by commas:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

        //transferring string numbers into int
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine("Enter number to check:");
        int number = int.Parse(Console.ReadLine());
        

        
        if (CheckNumberCountExist(number, array) == true)
        {
            CountNumber(number, array);
        }
  

    }

    static void CountNumber(int num, int[] array)
    {
        Array.Sort(array);
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Number {0} appears {1} times.", num, count);
    }
        
        
        static bool CheckNumberCountExist(int num, int [] array)
        {
            int isNumberExist = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==num)
                {
                    isNumberExist ++;
                    sum++;
                }
            }


            if (sum == 0)
            {
                Console.WriteLine("Invalid input! Number you have entered does not exist in array.");
                return false;
            }
            else
            {
                return true;
            }
        }
}
