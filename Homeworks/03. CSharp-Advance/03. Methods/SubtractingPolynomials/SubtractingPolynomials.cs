using System;

class SubstractingPolynomials
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] input1 = Console.ReadLine().Split(' ');
        string[] input2 = Console.ReadLine().Split(' ');

        int[] firstPolynomial = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstPolynomial[i] = int.Parse(input1[i]);
        }

        int[] secondPolynomial = new int[n];

        for (int i = 0; i < n; i++)
        {
            secondPolynomial[i] = int.Parse(input2[i]);
        }

        SumOfTwoPolynomials(firstPolynomial, secondPolynomial, n);
        SubstractOfTwoPolynomials(firstPolynomial, secondPolynomial, n);
        MultiplicationOfTwoPolynomials(firstPolynomial, secondPolynomial, n);
    }

    static void SumOfTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial, int n)
    {
        int[] sums = new int[n];

        for (int i = 0; i < n; i++)
        {
            sums[i] = firstPolynomial[i] + secondPolynomial[i];
        }

        Console.WriteLine(string.Join(" ", sums));
    }

    private static void SubstractOfTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial, int n)
    {
        int[] substracts = new int[n];

        for (int i = 0; i < n; i++)
        {
            substracts[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        Console.WriteLine(string.Join(" ", substracts));
    }

    private static void MultiplicationOfTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial, int n)
    {
        int[] multiplication = new int[n];

        for (int i = 0; i < n; i++)
        {
            multiplication[i] = firstPolynomial[i] * secondPolynomial[i];
        }

        Console.WriteLine(string.Join(" ", multiplication));
    }
}

