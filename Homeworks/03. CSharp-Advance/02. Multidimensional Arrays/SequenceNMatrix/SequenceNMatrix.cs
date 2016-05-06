/*Problem 3. Sequence n matrix
• We are given a matrix of strings of size  N x M . 
  Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
  column or diagonal.
• Write a program that finds the longest sequence of equal strings in the matrix.

Example:
matrix                 result                matrix             result
N=3; M=4                                     N=3; M=3
ha fifi ho hi          ha, ha, ha            s qq s             s, s, s
fo ha hi xx                                  pp pp s 
xxx ho ha xx                                 pp qq s                            */

using System;
using System.Linq;

class SequenceNMatrix
{
    static string bestSequence = String.Empty;
    static int bestCount = 0;

    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] rowsNum = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = rowsNum[col];
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckForSequence(matrix, row, col);
            }
        }

        Console.WriteLine(bestCount);
    }

    private static void CheckForSequence(string[,] matrix, int row, int col)
    {
        int diagonal = CheckDiagonal(matrix, row, col);
        int right = CheckRight(matrix, row, col);
        int down = CheckDown(matrix, row, col);

        if (diagonal > bestCount ||
            right > bestCount ||
            down > bestCount)
        {
            bestCount = Math.Max(Math.Max(right, diagonal), down);
            bestSequence = string.Join(", ",
                Enumerable
                .Repeat(matrix[row, col], bestCount)
                .ToArray());
        }
    }

    private static int CheckDown(string[,] matrix, int row, int col)
    {
        int count = 0;
        string checkString = matrix[row, col];
        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, col] == checkString)
                ++count;
            else
                break;
        }
        return count;
    }

    private static int CheckRight(string[,] matrix, int row, int col)
    {
        int count = 0;
        string checkString = matrix[row, col];
        for (int j = col; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] == checkString)
                ++count;
            else
                break;
        }
        return count;
    }

    private static int CheckDiagonal(string[,] matrix, int row, int col)
    {
        int count = 0;
        string checkString = matrix[row, col];
        for (int i = row, j = col; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (matrix[i, j] == checkString)
                ++count;
            else
                break;
        }

        return count;
    }

}

