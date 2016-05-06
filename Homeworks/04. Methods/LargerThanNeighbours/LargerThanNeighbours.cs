/*Problem 5. Larger than neighbours
 • Write a method that checks if the element at given position in given array of integers is 
   larger than its two neighbours (when such exist).*/


using System;
class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array:");
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("Enter position in array to check: ");
        int position = int.Parse(Console.ReadLine());


        if (CheckPositionExist(position, array) == true)
        {
            LargerThanItsTwoNeighbours(position, array);
        }
    }


    static void LargerThanItsTwoNeighbours(int position, int[] array)
    {
        int num = array[position];
        if (array[position - 1] < num && num > array[position + 1])
        {
            Console.WriteLine("Number {0} is larger than its two neighbours.", num);
        }
        else
        {
            Console.WriteLine("Number {0} is not larger than its two neighbours.", num);
        }
    }


    static bool CheckPositionExist(int position, int[] array)
    {
        if (position >= (array.Length - 1))
        {
            Console.WriteLine("Invalid input! \nPosition you have entered doesn't exist in array or doesn't have two neighbours.");
            return false;
        }
        else
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid input! \nPosition you have entered doesn't exist in array or doesn't have two neighbours.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
