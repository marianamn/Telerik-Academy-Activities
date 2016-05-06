/*Problem 12. Subtracting polynomials
 • Extend the previous program to support also subtraction and multiplication of polynomials.*/

using System;
class SubtractingPolynomials
{
    static void Main(string[] args)
    {
        Console.Write("Enter first polynomial degree:");
        int n = int.Parse(Console.ReadLine());
        int[] polynomial1 = new int[n + 1];
        PolynomialConsoleInput(n + 1, polynomial1);
        Console.WriteLine("First polynomial: {0}", PrintPolynomial(n, 0, polynomial1));
        Console.WriteLine();

        Console.Write("Enter second polynomial degree:");
        int m = int.Parse(Console.ReadLine());
        int[] polynomial2 = new int[m + 1];
        PolynomialConsoleInput(m + 1, polynomial2);
        Console.WriteLine("Second polynomial: {0}", PrintPolynomial(m, 0, polynomial2));
        Console.WriteLine();


        //product of two polynomials
        Console.WriteLine("Product of the two polynomials is:");
        ProductOfTwoPolynomials(polynomial1, polynomial2);

        //substraction of two polynomials
        Console.WriteLine("Substraction of the two polynomials is:");
        SubstractionOfTwoPolynomials(polynomial1, polynomial2);
        
    }

    public static void PolynomialConsoleInput(int n, int[] array)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write("x^{0}=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static string PrintPolynomial(int end, int start, int[] array)
    {
        string polynomial = "";
        for (int i = end; i >= start; i--)
        {
            if (i == end)
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


    static void ProductOfTwoPolynomials(int[] polynomial1, int[] polynomial2)
    {
        int[] product = new int[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < product.Length; i++)
        {
            if (i < Math.Min(polynomial1.Length, polynomial2.Length))
            {
                product[i] = polynomial1[i] * polynomial2[i];
            }
            else
            {
                if (polynomial1.Length > polynomial2.Length)
                {
                    product[i] = polynomial1[i];
                }
                else
                {
                    product[i] = polynomial2[i];
                }
            }
        }


        for (int i = 0; i <= product.Length - 1; i++)
        {
            if (i == (product.Length - 1))
            {
                Console.Write(product[i]);
            }
            else
            {
                Console.Write("{0}, ", product[i]);
            }
        }
        Console.WriteLine();
    }

    static void SubstractionOfTwoPolynomials(int[] polynomial1, int[] polynomial2)
    {
        int[] product = new int[Math.Max(polynomial1.Length, polynomial2.Length)];
        for (int i = 0; i < product.Length; i++)
        {
            if (i < Math.Min(polynomial1.Length, polynomial2.Length))
            {
                product[i] = polynomial1[i] - polynomial2[i];
            }
            else
            {
                if (polynomial1.Length > polynomial2.Length)
                {
                    product[i] = polynomial1[i];
                }
                else
                {
                    product[i] = polynomial2[i];
                }
            }
        }


        for (int i = 0; i <= product.Length - 1; i++)
        {
            if (i == (product.Length - 1))
            {
                Console.Write(product[i]);
            }
            else
            {
                Console.Write("{0}, ", product[i]);
            }
        }
        Console.WriteLine();
    }
}
