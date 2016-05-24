/*Problem 5. Maximal area sum
• Write a program that reads a text file containing a square matrix of numbers.
• Find an area of size  2 x 2  in the matrix, with a maximal sum of its elements. 
◦ The first line in the input file contains the size of matrix  N .
◦ Each of the next  N  lines contain  N  numbers separated by space.
◦ The output should be a single number in a separate text file.


Example:
input              output
 4                 17
 2 3 3 4 
 0 2 3 4 
 3 7 1 2 
 4 3 3 2                                         */

using System;
using System.Collections.Generic;
using System.IO;
class MaximalAreaSum
{
    static void Main(string[] args)
    {
        StreamReader file = new StreamReader(@"..\..\..\Txt Files\Matrix.txt");
        int n = int.Parse(file.ReadLine());
        int[,] matrix = new int[n, n];

        using (file)
        {
            for (int row = 0; row < n; row++)
            {
                string line = file.ReadLine();
                string[] rowsline = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(rowsline[col]);
                }
            }


            int bestSum = int.MinValue;
            int sum = 0;

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < n - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                          + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
}

