using System;

class SortingArray
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

        int[] sortedAscArray = SortAscending(array);
        Console.WriteLine(string.Join(" ", sortedAscArray));
    }

    static int[] SortAscending (int[] array)
    {
        Array.Sort(array);

        return array;
    }

    static int[] SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);

        return array;
    }
}