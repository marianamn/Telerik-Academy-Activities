/*Problem 2. Maximal sum
 • Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  
   that has maximal sum of its elements. */

/*Example for test (not given in problem)

Input       N = 4          2 3 9 9 9 5 6       Output    9 9 9 
            M = 7          5 6 9 9 9 2 1                 9 9 9
                           6 4 9 9 9 2 6                 9 9 9                
                           1 2 4 6 8 3 6                                       */

/*Example for test (not given in problem)

Input       N = 4          2 3 9 9 9 5 6       Output    9 9 9 
            M = 7          5 6 9 9 9 2 1                 9 9 9
                           6 4 9 100 9 2 6               9 100 9                
                           1 2 4 6 8 3 6                                       */


using System;
class MaximalSum
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        long n = int.Parse(sizes[0]);
        long m = int.Parse(sizes[1]);

        long[,] matrix = new long[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] rowsNum = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(rowsNum[col]);
            }
        }

        //PrintMatrix(matrix, n, m);

        long bestSum = int.MinValue;
        long sum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine(bestSum);
    }

    private static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j == m - 1)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                else
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}

/// solution with UI elements
/// 
//using System;
//class MaximalSum
//{
//    static void Main()
//    {
//        Console.Write("Enter martix rows N (>= 3): ");
//        int n = int.Parse(Console.ReadLine());
//
//        Console.Write("Enter martix columns M (>= 3): ");
//        int m = int.Parse(Console.ReadLine());
//
//        int[,] matrix = new int[n, m];
//
//        Console.WriteLine("Enter martix numbers for each row, separated by space: ");
//
//        for (int row = 0; row < n; row++)
//        {
//            Console.Write("row[{0}]=", row);
//            string input = Console.ReadLine();
//            string[] rowsNum = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            for (int col = 0; col < m; col++)
//            {
//                matrix[row, col] = int.Parse(rowsNum[col]);
//            }
//        }
//
//        int bestSum = int.MinValue;
//        int sum = 0;
//        int bestRow = 0;
//        int bestCol = 0;
//
//        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
//        {
//            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
//            {
//                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
//                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
//                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
//                if (sum > bestSum)
//                {
//                    bestSum = sum;
//                    bestRow = row;
//                    bestCol = col;
//                }
//            }
//        }
//
//        Console.WriteLine("The square  3x3 that has maximal sum of its elements is:");
//        Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
//        Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
//        Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
//        Console.WriteLine("The maximal sum is: {0}", bestSum);
//    }
//}

