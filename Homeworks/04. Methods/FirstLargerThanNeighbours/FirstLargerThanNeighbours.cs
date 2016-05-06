using System;

class FirstLargerThanNeighbours
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

        int index = LargerThanTwoNeighbours(array);

        Console.WriteLine(index);
    }

    static int LargerThanTwoNeighbours(int[] array)
    {
        int index = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }

        }

        return index;
    }
}
