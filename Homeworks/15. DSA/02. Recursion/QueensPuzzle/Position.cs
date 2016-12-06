namespace QueensPuzzle
{
    using System;

    public class Position
    {
        private static Position queenAbove;
        private int numberOfQueens;
        private int line;
        private int row;
        private Position parent;

        public Position(int line, int row, Position parent)
        {
            this.line = line;
            this.row = row;
            this.parent = parent;
            this.numberOfQueens = 8;
        }

        public void WalkThroughTree()
        {
            if (this.line == this.numberOfQueens)
            {
                PrintSolution(this);
                return;
            }

            for (var r = 0; r < this.numberOfQueens; r++)
            {
                queenAbove = this;
                while (queenAbove.row >= 0 && r != queenAbove.row
                        && r - queenAbove.row != this.line + 1 - queenAbove.line
                        && queenAbove.row - r != this.line + 1 - queenAbove.line)
                {
                    queenAbove = queenAbove.parent;
                }

                if (queenAbove.line == 0)
                {
                    new Position(this.line + 1, r, this).WalkThroughTree();
                }
            }
        }

        private static void PrintSolution(Position node)
        {
            Console.Write("Positions: ");
            while (node.row >= 0)
            {
                Console.Write(string.Empty + (char)('a' + node.row) + node.line + " ");
                node = node.parent;
            }

            Console.WriteLine();
        }
    }
}
