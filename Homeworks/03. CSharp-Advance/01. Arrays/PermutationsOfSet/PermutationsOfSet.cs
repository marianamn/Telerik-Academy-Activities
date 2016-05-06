/*Problem 19.* Permutations of set
• Write a program that reads a number  N  and generates and prints all the permutations of the numbers
 [ 1 … N ].

Example:
N      result
3       {1, 2, 3}  
        {1, 3, 2}  
        {2, 1, 3}  
        {2, 3, 1}  
        {3, 1, 2}  
        {3, 2, 1}   */



using System;
class PermutationsOfSet
 { 
     static void Main() 
     {
         Console.WriteLine("Enter N");
         int n = int.Parse(Console.ReadLine());

         int[] arr = new int[n]; 
         for (int i = 0; i < arr.Length; i++) 
         { 
             arr[i] = i + 1; 
         } 
 
         Permutation(arr, 0); 
     } 
 
     private static void Permutation(int[] arr, int index) 
     { 
         if (index == arr.Length) 
         { 
             Console.WriteLine(string.Join(", ", arr)); 
             return; 
         } 
 
         for (int i = index; i < arr.Length; i++) 
         { 
             Swap(arr, i, index); 
             Permutation(arr, index + 1); 
             Swap(arr, i, index); 
         } 
     } 
 
     private static void Swap(int[] arr, int i, int j) 
     { 
         int temp = arr[i]; 
         arr[i] = arr[j]; 
         arr[j] = temp; 
     } 
 } 