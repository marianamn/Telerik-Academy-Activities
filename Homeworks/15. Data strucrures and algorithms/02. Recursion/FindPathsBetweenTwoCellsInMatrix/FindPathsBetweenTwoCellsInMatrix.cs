﻿// We are given a matrix of passable and non-passable cells.
// Write a recursive program for finding all paths between two cells in the matrix.

namespace FindPathsBetweenTwoCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class FindPathsBetweenTwoCellsInMatrix
    {
        private static char[,] lab =
                     {
                               { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
                               { '*', '*', ' ', '*', ' ', '*', ' ' },
                               { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                               { ' ', '*', '*', '*', '*', '*', ' ' },
                               { ' ', ' ', ' ', ' ', ' ', ' ', 'e' },
                             };

        private static List<char> path = new List<char>();

        public static void Main()
        {
            FindPathToExit(0, 0, 'S');
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void FindPathToExit(int row, int col, char direction)
        {
            // To see matrix full paths uncomment below row
            // PrintLabyrinth(row, col);
            if (!InRange(row, col))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            // Append the current direction to the path
            path.Add(direction);

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                PrintPath(path);
            }

            if (lab[row, col] == ' ')
            {
                // Temporary mark the current cell as visited
                lab[row, col] = 's';

                // Recursively explore all possible directions
                FindPathToExit(row, col - 1, 'L'); // left
                FindPathToExit(row - 1, col, 'U'); // up
                FindPathToExit(row, col + 1, 'R'); // right
                FindPathToExit(row + 1, col, 'D'); // down

                // Mark back the current cell as free
                lab[row, col] = ' ';
            }

            // Remove the last direction from the path
            path.RemoveAt(path.Count - 1);
        }

        private static void PrintLabyrinth(int currentRow, int currentCol)
        {
            for (int row = -1; row <= lab.GetLength(0); row++)
            {
                Console.WriteLine();

                for (int col = -1; col <= lab.GetLength(1); col++)
                {
                    if ((row == currentRow) && (col == currentCol))
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write("x");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (!InRange(row, col))
                    {
                        Console.Write(" ");
                    }
                    else if (lab[row, col] == ' ')
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(lab[row, col]);
                    }

                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        private static void PrintPath(List<char> path)
        {
            Console.Write("Found path to the exit: ");
            foreach (var dir in path)
            {
                Console.Write(dir);
            }

            Console.WriteLine();
        }
    }
}