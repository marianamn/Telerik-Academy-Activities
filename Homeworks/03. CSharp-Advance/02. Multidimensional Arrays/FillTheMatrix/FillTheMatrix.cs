/*Problem 1. Fill the matrix
• Write a program that fills and prints a matrix of size (n, n) as shown below:
On the first line you will receive the number N
On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix

Numbers on a row must be separated by a single spacebar
Each row must be on a new line

Example for  n=4 :
a)                 b)               c)               d)*
1 5 9  13          1 8 9  16        7 11 14 16        1 12 11 10   
2 6 10 14          2 7 10 15        4 8  12 15        2 13 16 9 
3 7 11 15          3 6 11 14        2 5  9  13        3 14 15 8
4 8 12 16          4 5 12 13        1 3  6  10        4 5  6  7           */


using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string caseLetter = Console.ReadLine();
        int[,] matrix = new int[n, n];

        switch (caseLetter)
        {
            case "a": matrix = FillMatrixInCaseA(matrix, n); break;
            case "b": matrix = FillMatrixInCaseB(matrix, n); break;
            case "c": matrix = FillMatrixInCaseC(matrix, n); break;
            case "d": matrix = FillMatrixInCaseD(matrix, n); break;
            default: Console.WriteLine("Invalid case!"); break;
        }

        PrintMatrix(matrix, n);
    }

    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n - 1)
                {
                    Console.Write(matrix[i, j]);
                }
                else
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }

    private static int[,] FillMatrixInCaseA(int[,] matrix, int n)
    {
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }

        return matrix;
    }

    private static int[,] FillMatrixInCaseB(int[,] matrix, int n)
    {
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }

        return matrix;
    }

    private static int[,] FillMatrixInCaseC(int[,] matrix, int n)
    {
        //below diagonal
        int count = 1;
        int rows = 0;
        int cols = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;

            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = count++;
            }
        }

        //above diagonal
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;

            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = count++;
            }
        }

        return matrix;
    }

    private static int[,] FillMatrixInCaseD(int[,] matrix, int n)
    {
        int count = 1;
        int rows = 0;
        int cols = 0;
        int maxRows = n - 1;
        int maxCols = n - 1;

        do
        {
            for (int i = rows; i <= maxRows; i++)
            {
                matrix[i, cols] = count;
                count++;
            }

            cols++;

            for (int i = cols; i <= maxCols; i++)
            {
                matrix[maxRows, i] = count;
                count++;
            }

            maxRows--;

            for (int i = maxRows; i >= rows; i--)
            {
                matrix[i, maxCols] = count;
                count++;
            }

            maxCols--;

            for (int i = maxCols; i >= cols; i--)
            {
                matrix[rows, i] = count;
                count++;
            }

            rows++;
        } while (count <= n * n);

        return matrix;
    }
}


/// solution with UI elements
/// 
//using System;
//class FillTheMatrix
//{
//    static void Main()
//    {
//        Console.Write("Enter martix size n: ");
//        int n = int.Parse(Console.ReadLine());
//
//
//        int[,] matrix = new int[n, n];
//
//        Console.WriteLine();
//        Console.WriteLine("a)");
//        int count = 1;
//        for (int col = 0; col < n; col++)
//        {
//            for (int row = 0; row < n; row++)
//            {
//                matrix[row, col] = count;
//                count++;
//            }
//        }
//        PrintMatrix(n, matrix);
//
//
//        Console.WriteLine();
//        Console.WriteLine("b)");
//        count = 1;
//        for (int col = 0; col < n; col++)
//        {
//            if (col % 2 == 0)
//            {
//                for (int row = 0; row < n; row++)
//                {
//                    matrix[row, col] = count;
//                    count++;
//                }
//            }
//            else
//            {
//                for (int row = n - 1; row >= 0; row--)
//                {
//                    matrix[row, col] = count;
//                    count++;
//                }
//            }
//        }
//        PrintMatrix(n, matrix);
//
//
//        Console.WriteLine();
//        Console.WriteLine("c)");
//        count = 1;
//        int rows = 0;
//        int cols = 0;
//        //numbers under the diagonal
//        for (int i = n - 1; i >= 0; i--)
//        {
//            rows = i;
//            cols = 0;
//            while (rows < n && cols < n)
//            {
//                matrix[rows++, cols++] = count++;
//            }
//        }
//        //numbers above the diagonal
//        for (int j = 1; j < n; j++)
//        {
//            rows = j;
//            cols = 0;
//            while (rows < n && cols < n)
//            {
//                matrix[cols++, rows++] = count++;
//            }
//        }
//
//        PrintMatrix(n, matrix);
//
//
//        Console.WriteLine();
//        Console.WriteLine("d)");
//        count = 1;
//        rows = 0;
//        cols = 0;
//        int maxRow = n - 1;
//        int maxCol = n - 1;
//
//        do
//        {
//            for (int i = rows; i <= maxRow; i++)
//            {
//                matrix[i, cols] = count;
//                count++;
//            }
//            cols++;
//
//
//            for (int i = cols; i <= maxCol; i++)
//            {
//                matrix[maxRow, i] = count;
//                count++;
//            }
//            maxRow--;
//
//            for (int i = maxRow; i >= rows; i--)
//            {
//                matrix[i, maxCol] = count;
//                count++;
//            }
//            maxCol--;
//
//            for (int i = maxCol; i >= cols; i--)
//            {
//                matrix[rows, i] = count;
//                count++;
//            }
//            rows++;
//        }
//        while (count <= n * n);
//
//
//        PrintMatrix(n, matrix);
//
//    }
//
//    static void PrintMatrix(int n, int[,] matrix)
//    {
//        for (int row = 0; row < matrix.GetLength(0); row++)
//        {
//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                Console.Write("{0,3}", matrix[row, col]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
