namespace _02.EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        public static void Main()
        {
            int n = 10;
            int[] numbers = ReadNumber(0, n);

            bool increasing = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    increasing = false;
                    break;
                }
                else
                {
                    increasing = true;
                }
            }

            if (increasing)
            {
                Console.WriteLine(string.Join(" < ", numbers));
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }

        private static int[] ReadNumber(int v, int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Exception");
                }
            }

            return numbers;
        }
    }
}
