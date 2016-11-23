// 8. Modify the above program to check whether a path exists between two cells without finding all possible paths.
//    Test it over an empty 100 x 100 matrix.

// 9. Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.

namespace IsPathsExistsBetweenTwoCellsInMatrix
{
    using System;

    public class ShorthestPathInMatrix
    {
        public static void Main()
        {
            var lab = new Labyrinth(12); // 100
            lab.Print();
            Console.WriteLine();
            lab.Fill();
            Console.WriteLine("Labyrinth:\n");
            lab.Print();
        }
    }
}
