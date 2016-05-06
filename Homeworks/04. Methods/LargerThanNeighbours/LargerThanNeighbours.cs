using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        int count = LargerThanItsTwoNeighbours(array);

        Console.WriteLine(count);
    }


    static int LargerThanItsTwoNeighbours(int[] array)
    {
        int count = 0;

        for (int i = 1; i < array.Length - 2; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i-1])
            {
                count++;
            }
        }

        return count;
    }
}
