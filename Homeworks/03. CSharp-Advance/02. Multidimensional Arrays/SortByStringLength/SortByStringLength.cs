/*Problem 5. Sort by string length
 • You are given an array of strings. Write a method that sorts the array by the length of its elements 
  (the number of characters composing them).   */


/*Example for test (not given in problem)
input                                       result
abc, dc, a, ssfd, e                         a, e, dc, abc, ssfd
*/


using System;
class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter string elements, separated by comma: ");
        string input = Console.ReadLine();
        string[] array = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length-1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }

        Console.WriteLine();
    }
}