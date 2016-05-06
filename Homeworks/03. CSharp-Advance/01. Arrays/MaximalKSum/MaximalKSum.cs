/*Problem 6. Maximal K sum
• Write a program that reads two integer numbers  N  and  K  and an array of  N  elements from the console.
• Find in the array those  K  elements that have maximal sum.
*/

using System;
class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        int maxSum = 0;

        for (int i = 0; i < k; i++)
        {
            maxSum += array[i];
        }

        Console.WriteLine(maxSum);
    }
}

///more UI specified solution
///
//using System;
//class MaximalKSum
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter array lenght n: ");
//        int n = int.Parse(Console.ReadLine());
//
//        int[] array = new int[n];
//
//        Console.WriteLine("Enter number k: ");
//        int k = int.Parse(Console.ReadLine());
//        if (k > n)
//        {
//            Console.WriteLine("Incorrect input for k (k <= n)!");
//        }
//
//
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("array[{0}] = ", i);
//            array[i] = int.Parse(Console.ReadLine());
//        }
//
//        int sum = 0;
//
//        Array.Sort(array);
//        Array.Reverse(array);
//
//        for (int i = 0; i < k; i++)
//        {
//            sum += array[i];
//        }
//
//        Console.WriteLine("The sum of the biggest {0} elements is: {1}", k, sum);
//    }
//}
