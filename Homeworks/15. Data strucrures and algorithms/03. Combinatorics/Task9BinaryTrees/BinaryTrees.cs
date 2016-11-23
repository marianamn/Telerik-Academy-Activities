namespace Task9BinaryTrees
{
    using System;
    using System.Numerics;

    public class BinaryTrees
    {
        private const int CapitalLetters = 26;
        private static long[] memo;

        public static void Main()
        {
            var input = Console.ReadLine();
            var groupsOfBalls = new int[CapitalLetters];

            foreach (var ball in input)
            {
                groupsOfBalls[ball - 'A']++;
            }

            int n = input.Length;
            memo = new long[n + 1];

            var factorials = new long[n + 1];
            factorials[0] = 1;

            for (int i = 0; i < n; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            long result = factorials[n];
            foreach (var group in groupsOfBalls)
            {
                result /= factorials[group];
            }

            BigInteger answer = result;
            answer *= Trees(n);
            Console.WriteLine(answer);
        }

        private static long Trees(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (memo[n] > 0)
            {
                return memo[n];
            }

            long result = 0;
            for (int i = 0; i < n; i++)
            {
                result += Trees(i) * Trees(n - 1 - i);
            }

            memo[n] = result;
            return result;
        }
    }
}