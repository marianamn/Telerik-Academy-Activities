/*Problem 15. Prime numbers
• Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. 
The program should print the biggest prime number which is <= N.
Print the biggest prime number which is <= N
Input
Use the Sieve of Eratosthenes algorithm.*/


using System;
class PrimeNumbers
{
    static void Main()
    {
        //To find all the prime numbers less than or equal to a given integer n by Eratosthenes' method:
        //1.Create a list of consecutive integers from 2 through n: (2, 3, 4, ..., n).
        //2.Initially, let p equal 2, the first prime number.
        //3.Starting from p, enumerate its multiples by counting to n in increments of p, and mark them in the list (these will be 2p, 3p, 4p, ... ; the p itself should not be marked).
        //4.Find the first number greater than p in the list that is not marked. If there was no such number, stop. Otherwise, let p now equal this new number (which is the next prime), and repeat from step 3.

        long n = long.Parse(Console.ReadLine()) + 1; 
        
        bool[] numbers = new bool[n];
        
        for (int i = 2; i < n; i++)
        {
            numbers[i] = true;                     // initially all set to true.
        }
        
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            for (int j = i * 2; j < n; j += i)
            {
                numbers[j] = false;
            }
        }
        
        for (long i = n - 1; i >= 0; i--)
        {
            if (numbers[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}