// * Write a recursive program to solve the "8 Queens Puzzle" with backtracking.
// Learn more at: wiki/Eight queens puzzle

namespace QueensPuzzle
{
    public class QueensPuzzle
    {
        public static void Main()
        {
            int line = 0;
            int row = -1;
            Position parent = null;
            new Position(line, row, parent).WalkThroughTree();
        }
    }
}
