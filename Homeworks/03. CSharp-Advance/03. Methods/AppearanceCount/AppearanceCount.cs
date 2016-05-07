using System;

class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        
        int number = int.Parse(Console.ReadLine());
        int count = CountNumberAppearance(number, numbers);

        Console.WriteLine(count);
    }

    static int CountNumberAppearance(int num, int[] array)
    {
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

        return count;
    }
}
