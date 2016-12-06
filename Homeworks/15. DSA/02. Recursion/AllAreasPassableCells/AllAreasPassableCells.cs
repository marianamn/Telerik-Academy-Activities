// * We are given a matrix of passable and non-passable cells.
//  Write a recursive program for finding all areas of passable cells in the matrix.

namespace AllAreasPassableCells
{
    using System;

    public class AllAreasPassableCells
    {
        public static void Main()
        {
            var lab = new Labyrinth(10);

            Console.WriteLine("Empty labyrinth:\n");
            lab.Print();
            Console.WriteLine();
            lab.Fill();
            Console.WriteLine("Filled labyrinth:\nPassable cells filled with numbers, unpassable - with 'u' or 'X'\n");
            lab.Print();
        }
    }
}
