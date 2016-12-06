namespace Task2ColoredBunnies
{
    using System;
    using System.Collections.Generic;

    public class ColoredBunnies
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> replies = new List<int>();

            for (int i = 0; i < n; i++)
            {
                replies.Add(int.Parse(Console.ReadLine()));
            }

            int totalBunnies = GetMinimumBunnies(n, replies);
            Console.WriteLine(totalBunnies);
        }

        private static int GetMinimumBunnies(int n, List<int> replies)
        {
            var totalBunnies = 0;

            for (int i = 0; i < n;)
            {
                int answer = replies[i];
                replies.RemoveAll(a => a == answer);

                var currentNumber = n - replies.Count;
                n = replies.Count;

                var toBeMultiplied = currentNumber / (answer + 1);
                totalBunnies += toBeMultiplied * (answer + 1);

                if (currentNumber % (answer + 1) != 0)
                {
                    totalBunnies += answer + 1;
                }
            }

            return totalBunnies;
        }
    }
}
