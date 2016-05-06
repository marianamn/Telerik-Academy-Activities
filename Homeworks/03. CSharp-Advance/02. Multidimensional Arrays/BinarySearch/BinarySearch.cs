/*Problem 4. Binary search
 • Write a program, that reads from the console an array of  N  integers and an integer  K, 
  sorts the array and using the method  Array.BinSearch() finds the largest number in the array
  which is ≤  K . */


/*Example for tests (not given in problem)
input                                       result
n=5   K=6    array = {2 3 4 5 6}             6
n=5   K=6    array = {2 3 4 5 1}             5
n=5   K=-1   array = {-2 -3 -4 -5 -1}       -1
n=5   K=1    array = {2 3 4 5 6}             there is no such number     */


using System;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter array numbers: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        Array.Sort(array);
        int maxValue = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (array[i]<=k)
            {
                maxValue = array[i];
            }
        }


        int positionLargest = Array.BinarySearch(array, maxValue);

        if (array[0] > k)
        {
           Console.WriteLine("There isn't number in the array which is <= K is:"); 
        }
        else
        {
            Console.WriteLine("Largest number in the array which is <= K is: {0}", array[positionLargest]);
        }
    }
}
