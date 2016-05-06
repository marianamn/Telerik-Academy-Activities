/*Problem 7.* Largest area in matrix
 • Write a program that finds the largest area of equal neighbour elements in a rectangular matrix 
   and prints its size.

Example:
matrix             result
1 3 2 2 2 4          13
3 3 3 2 4 4 
4 3 1 2 3 3 
4 3 1 3 3 1 
4 3 3 3 1 1 
 
Hint: you can use the algorithm Depth-first search or Breadth-first search.*/

using System;
class LargestAreaInMatrix
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        int[,] matrix = new int[n, m];
        bool[,] visited = new bool[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] rowsNum = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(rowsNum[col]);
            }
        }

        PrintResult(matrix, visited);
    }

    //Depth-first search method
    static int DepthFirstSearch(int[,] matrix, bool[,] visited, int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }

        if (visited[row, col])
        {
            return 0;
        }

        if (matrix[row, col] != value)
        {
            return 0;
        }

        visited[row, col] = true;

        return DepthFirstSearch(matrix, visited, row, col + 1, value) +
               DepthFirstSearch(matrix, visited, row, col - 1, value) +
               DepthFirstSearch(matrix, visited, row + 1, col, value) +
               DepthFirstSearch(matrix, visited, row - 1, col, value) + 1;
    }

    static void PrintResult(int[,] matrix, bool[,] visited)
    {
        int result = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DepthFirstSearch(matrix, visited, row, col, matrix[row, col]));
            }
        }

        Console.WriteLine(result);
    }
}

