// Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
// Write a program to test whether the method works correctly.

namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequenceOfEqualNumbers
    {
        private const string EndOfInput = "";

        public static void Main()
        {
            List<int> numbers = ReadNumbersFromConsole();
            List<int> longestSubsequence = FindLongestSequence(numbers);

            if (longestSubsequence.Count == 1)
            {
                Console.WriteLine("There is no sequence with equal elements!");
            }
            else
            {
                Console.WriteLine("Longest Subsequence of equal elements: { " + string.Join(", ", longestSubsequence) + " }");
            }
        }

        public static List<int> FindLongestSequence(List<int> numbers)
        {
            var currentElement = numbers[0];
            var currentLength = 0;
            var longestSequenceElement = 0;
            var longestSequenceLength = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == currentElement)
                {
                    currentLength++;
                }
                else
                {
                    currentElement = numbers[i];
                    currentLength = 1;
                }

                if (currentLength > longestSequenceLength)
                {
                    longestSequenceLength = currentLength;
                    longestSequenceElement = currentElement;
                }
            }

            List<int> longestSubsequence = new List<int>();
            for (int i = 0; i < longestSequenceLength; i++)
            {
                longestSubsequence.Add(longestSequenceElement);
            }

            return longestSubsequence;
        }

        private static List<int> ReadNumbersFromConsole()
        {
            Console.WriteLine("Enter numbers:");

            List<int> numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != EndOfInput)
                {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    break;
                }
            }

            return numbers;
        }
    }
}
