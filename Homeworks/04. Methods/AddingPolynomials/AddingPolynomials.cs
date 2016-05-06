/*Problem 11. Adding polynomials
• Write a method that adds two polynomials.
• Represent them as arrays of their coefficients.

Example:
x^2 + 5 =  1 x^2 +  0 x +  5  => { 5 ,  0 ,  1 }*/



using System;
class AddingPolynomials
{
    static void Main(string[] args)
    {
        Console.Write("Enter first polynomial degree:");
        int n = int.Parse(Console.ReadLine());
        int[] polynomial1 = new int [n+1];
        PolynomialConsoleInput(n + 1, polynomial1);
        Console.WriteLine("First polynomial: {0}",PrintPolynomial(n, polynomial1));
        Console.WriteLine();

        Console.Write("Enter second polynomial degree:");
        int m = int.Parse(Console.ReadLine());
        int[] polynomial2 = new int[m+1];
        PolynomialConsoleInput(m + 1, polynomial2);
        Console.WriteLine("Second polynomial: {0}", PrintPolynomial(m, polynomial2));
        Console.WriteLine();

        Console.WriteLine("Sum of the two polynomials is:");
        SumOfTwoPolynomials(polynomial1, polynomial2);

    }

    

    public static void PolynomialConsoleInput(int n, int[] array)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }

    static string PrintPolynomial(int n, int[] array)
    {
        string polynomial = "";
        for (int i = n; i >= 0; i--)
        {
            if (i == n)
            {
                polynomial = polynomial + array[i] + "*" + "x^" + i;
            }
            else
            {
                polynomial = polynomial + "+" + array[i] + "*" + "x^" + i;
            }

        }
        return polynomial;
    }

    static void SumOfTwoPolynomials(int[] polynomial1, int[] polynomial2)
    {
        int[] sum = new int[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < sum.Length; i++)
        {
            if (i < Math.Min(polynomial1.Length, polynomial2.Length))
            {
                sum[i] = polynomial1[i] + polynomial2[i];
            }
            else
            {
                if (polynomial1.Length > polynomial2.Length) 
                 {
                     sum[i] = polynomial1[i]; 
                 } 
                 else 
                 {
                     sum[i] = polynomial2[i]; 
                 } 
            }
        }


        for (int i = 0; i <= sum.Length-1; i++)
        {
            if (i == (sum.Length - 1))
            {
                Console.Write(sum[i]);
            }
            else
            {
                Console.Write("{0}, ", sum[i]);
            }
        }
        Console.WriteLine();
    }

    
}
