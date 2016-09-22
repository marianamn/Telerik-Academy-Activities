using System;
using System.Text;

namespace MatrixRefactoring
{
    public class Matrix
    {
        private readonly Cell[] targetCells;
        private int rows;
        private int cols;
        private int startIndex;

        public Matrix(int rows, int cols, int startIndex)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.StartIndex = startIndex;

            this.Field = new int[rows, cols];
            this.targetCells = new[]
                              {
                                new Cell(1, 1), new Cell(1, 0), new Cell(1, -1), new Cell(0, -1),
                                new Cell(-1, -1), new Cell(-1, 0), new Cell(-1, 1), new Cell(0, 1)
                              };
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Matrix rows count cannot be less than 0!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Matrix colls count cannot be less than 0!");
                }

                this.cols = value;
            }
        }

        public int StartIndex
        {
            get
            {
                return this.startIndex;
            }

            private set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Start index cannot be less than 0!");
                }

                this.startIndex = value;
            }
        }

        public int[,] Field { get; set; }

        public override string ToString()
        {
            var printedMatrix = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    printedMatrix.AppendFormat("{0,3}", this.Field[i, j]);
                }

                printedMatrix.Append(Environment.NewLine);
            }

            return printedMatrix.ToString();
        }

        public void FillMatrix()
        {
            var currentCell = new Cell(0, 0);
            var currentCellValue = 1;

            while (currentCell != null)
            {
                this.Field[currentCell.X, currentCell.Y] = currentCellValue;
                currentCell = this.MoveToCell(currentCell) ?? this.FindFirstEmpty();

                currentCellValue++;
            }
        }

        private Cell MoveToCell(Cell cell)
        {
            for (int i = this.startIndex; i < (this.targetCells.Length + this.startIndex); i++)
            {
                Cell nextCell = cell + this.targetCells[i % this.targetCells.Length];

                if (this.IsValidDestination(nextCell))
                {
                    this.startIndex = i % this.targetCells.Length;
                    return nextCell;
                }
            }

            return null;
        }

        private bool IsValidDestination(Cell cell)
        {
            bool ifCellInBorder = cell.X >= 0 && cell.X < this.Rows && cell.Y >= 0
                   && cell.Y < this.Cols && this.Field[cell.X, cell.Y] == 0;

            return ifCellInBorder;
        }

        private Cell FindFirstEmpty()
        {
            Cell result = new Cell(0, 0);

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (this.Field[i, j] == 0)
                    {
                        this.startIndex = 0;
                        result.X = i;
                        result.Y = j;
                        return result;
                    }
                }
            }

            return null;
        }
    }
}
