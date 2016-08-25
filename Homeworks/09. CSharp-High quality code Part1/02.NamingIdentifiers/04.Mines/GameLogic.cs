namespace _04.Mines
{
    using System;
    using System.Collections.Generic;

    public class GameLogic
    {
        public void RankList(List<Points> points)
        {
            Console.WriteLine("\nPoints:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} steps", i + 1, points[i].UserName, points[i].UserPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rank list!\n");
            }
        }

        public void MoveNext(char[,] field, char[,] bombs, int row, int column)
        {
            char countBombs = CountBombs(bombs, row, column);
            bombs[row, column] = countBombs;
            field[row, column] = countBombs;
        }

        public void CreateBorders(char[,] field)
        {
            int row = field.GetLength(0);
            int column = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < column; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public char[,] CreatePlayField()
        {
            int playFieldRows = 5;
            int playFieldColumns = 10;
            char[,] board = new char[playFieldRows, playFieldColumns];

            for (int i = 0; i < playFieldRows; i++)
            {
                for (int j = 0; j < playFieldColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public char[,] CreateBombs()
        {
            const int MaxLength = 15;
            int rows = 5;
            int columns = 10;
            char[,] playField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> numbers = new List<int>();
            while (numbers.Count < MaxLength)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            foreach (int number in numbers)
            {
                int column = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playField[column, row - 1] = '*';
            }

            return playField;
        }

        private static void CalculatePoints(char[,] playfield)
        {
            int column = playfield.GetLength(0);
            int row = playfield.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playfield[i, j] != '*')
                    {
                        char count = CountBombs(playfield, i, j);
                        playfield[i, j] = count;
                    }
                }
            }
        }

        private static char CountBombs(char[,] bombs, int row, int column)
        {
            int count = 0;
            int rows = bombs.GetLength(0);
            int columns = bombs.GetLength(1);

            if ((row - 1 >= 0 && bombs[row - 1, column] == '*') ||
                (row + 1 < rows && bombs[row + 1, column] == '*') ||
                (column - 1 >= 0 && bombs[row, column - 1] == '*') ||
                (column + 1 < columns && bombs[row, column + 1] == '*') ||
                ((row - 1 >= 0) && (column - 1 >= 0) && bombs[row - 1, column - 1] == '*') ||
                ((row - 1 >= 0) && (column + 1 < columns) && bombs[row - 1, column + 1] == '*') ||
                ((row + 1 < rows) && (column - 1 >= 0) && bombs[row + 1, column - 1] == '*') ||
                ((row + 1 < rows) && (column + 1 < columns) && bombs[row + 1, column + 1] == '*'))
            {
                count++;
            }

            return char.Parse(count.ToString());
        }
    }
}
