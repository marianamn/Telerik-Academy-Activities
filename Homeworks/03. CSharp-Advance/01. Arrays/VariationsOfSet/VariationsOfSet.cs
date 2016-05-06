/*Problem 20.* Variations of set
• Write a program that reads two numbers  N  and  K  and generates all the variations of  K  elements
  from the set [ 1..N ].

Example:
N     K     result
3     2     {1, 1}  
            {1, 2}  
            {1, 3}  
            {2, 1}  
            {2, 2}  
            {2, 3}  
            {3, 1}  
            {3, 2}  
            {3, 3}   */

using System;
class VariationsOfSet
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());


        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Variations(arr, new int[k], 0);
    }

    private static void Variations(int[] nums, int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            arr[index] = nums[i];
            Variations(nums, arr, index + 1);
        }
    }

}