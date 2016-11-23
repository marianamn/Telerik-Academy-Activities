namespace Task3Deviders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Deviders
    {
        private static List<string> variations = new List<string>();

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Validate(n);

            StringBuilder inputNum = new StringBuilder(n);
            for (int i = 0; i < n; i++)
            {
                inputNum.Append(Console.ReadLine());
            }

            bool[] used = new bool[n];

            FindAllNumbers(0, string.Empty, used, inputNum.ToString());
            FindNumberWithMinDeviders();
        }

        private static void FindAllNumbers(int index, string variation, bool[] used, string inputNum)
        {
            int length = inputNum.Length;
            if (index == length)
            {
                variations.Add(variation);
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        FindAllNumbers(index + 1, variation + inputNum[i], used, inputNum);
                        used[i] = false;
                    }
                }
            }
        }

        private static void FindNumberWithMinDeviders()
        {
            int min = int.MaxValue;
            int minDevCount = int.MaxValue;

            foreach (var item in variations)
            {
                int num = int.Parse(item);
                int numDevCount = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        numDevCount++;
                    }
                }

                if (numDevCount < minDevCount)
                {
                    min = num;
                    minDevCount = numDevCount;
                }
            }

            Console.WriteLine(min);
        }

        private static void Validate(int n)
        {
            if (n <= 1 && n >= 5)
            {
                throw new Exception("Invalid input number");
            }
        }
    }
}
