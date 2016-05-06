/*Problem 6. First larger than neighbours
• Write a method that returns the index of the first element in array that is larger than its neighbours,
 or  -1 , if there’s no such element.
• Use the method from the previous exercise.
 */

using System;
class FirstLargerThanNeighbours
{
    static void Main()
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


        LargerThanTwoNeighbours(array);    
    }

    static void LargerThanTwoNeighbours(int[] array)
    {
        int position = -1;
        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i - 1] < array[i] && array[i] > array[i + 1])
            {
                position = i;
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine(position);
    }
}
