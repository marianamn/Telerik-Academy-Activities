/*Problem 10. Odd and Even Product
• You are given  n  integers (given in a single line, separated by a space).
• Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
• Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.

Examples:
numbers             result
2 1 1 6 3           yes 
product = 6  
  
3 10 4 6 5 1        yes 
product = 60  
  
4 3 2 5 2           no 
odd_product = 16  
even_product = 15                 */


using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < n; i ++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}