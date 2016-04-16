/*Problem 12.* Randomize the Numbers 1…N
 • Write a program that enters in integer  n  and prints the numbers  1, 2, …, n  in random order.

Examples:
n    randomized numbers 1…n
3    2 1 3 
10   3 4 8 2 6 7 9 1 10 5      

Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays. */

using System;
using System.Collections.Generic;


class RandomizeTheNumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            numbers.Add(i+1);
        }
        while (numbers.Count > 0) 
         { 
             int randomNumber = rnd.Next(0, numbers.Count); 
             Console.Write(numbers[randomNumber]); 
             if (numbers.Count > 1) 
             { 
                 Console.Write(" "); 
             } 
             numbers.RemoveAt(randomNumber); 
         } 
         Console.WriteLine(); 
     } 
 } 