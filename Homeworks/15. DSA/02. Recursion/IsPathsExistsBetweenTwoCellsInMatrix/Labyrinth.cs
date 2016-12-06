namespace IsPathsExistsBetweenTwoCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class Labyrinth
    {
        private static readonly Random Rand = new Random();
        private readonly int[] startCoordinates;
        private readonly int[] endCoordinates;
        private int currentNumber;
        private bool pathFound;

        public Labyrinth(int size)
        {
            this.Lab = new string[size, size];
            this.Size = size;
            this.startCoordinates = new[] { Rand.Next(0, this.Size), Rand.Next(0, this.Size) };
            this.endCoordinates = new[] { Rand.Next(0, this.Size), Rand.Next(0, this.Size) };
            this.GenerateLabyrinth();
            this.SetStartAndEnd(this.Lab);
        }

        public int Size { get; set; }

        public string[,] Lab { get; set; }

        public void Print()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (this.Lab[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (this.Lab[i, j] == "u")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (this.Lab[i, j] == "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (this.Lab[i, j] == "E")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(this.Lab[i, j].PadLeft(4));
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        public void Fill()
        {
            var currentPath = new Queue<int[]>();
            currentPath.Enqueue(this.startCoordinates);

            while (currentPath.Count > 0)
            {
                var currentCell = currentPath.Dequeue();

                bool canGoUp = currentCell[0] - 1 >= 0 
                               && (this.Lab[currentCell[0] - 1, currentCell[1]] == "0" 
                               || this.Lab[currentCell[0] - 1, currentCell[1]] == "E");
                bool canGoDown = currentCell[0] + 1 < this.Size 
                                 && (this.Lab[currentCell[0] + 1, currentCell[1]] == "0" 
                                 || this.Lab[currentCell[0] + 1, currentCell[1]] == "E");
                bool canGoRight = currentCell[1] + 1 < this.Size 
                                   && (this.Lab[currentCell[0], currentCell[1] + 1] == "0" 
                                   || this.Lab[currentCell[0], currentCell[1] + 1] == "E");
                bool canGoLeft = currentCell[1] - 1 >= 0 
                                 && (this.Lab[currentCell[0], currentCell[1] - 1] == "0" 
                                 || this.Lab[currentCell[0], currentCell[1] - 1] == "E");

                var currentNeighbours = new List<int[]>();

                if (canGoLeft)
                {
                    currentPath.Enqueue(new[] { currentCell[0], currentCell[1] - 1 });
                    currentNeighbours.Add(new[] { currentCell[0], currentCell[1] - 1 });
                }

                if (canGoRight)
                {
                    currentPath.Enqueue(new[] { currentCell[0], currentCell[1] + 1 });
                    currentNeighbours.Add(new[] { currentCell[0], currentCell[1] + 1 });
                }

                if (canGoUp)
                {
                    currentPath.Enqueue(new[] { currentCell[0] - 1, currentCell[1] });
                    currentNeighbours.Add(new[] { currentCell[0] - 1, currentCell[1] });
                }

                if (canGoDown)
                {
                    currentPath.Enqueue(new[] { currentCell[0] + 1, currentCell[1] });
                    currentNeighbours.Add(new[] { currentCell[0] + 1, currentCell[1] });
                }

                int.TryParse(this.Lab[currentCell[0], currentCell[1]], out this.currentNumber);

                foreach (var neighbour in currentNeighbours)
                {
                    if (this.Lab[neighbour[0], neighbour[1]] == "E")
                    {
                        this.pathFound = true;
                        break;
                    }

                    if (int.Parse(this.Lab[neighbour[0], neighbour[1]]) == 0)
                    {
                        this.Lab[neighbour[0], neighbour[1]] = (this.currentNumber + 1).ToString();
                    }
                }

                if (this.pathFound)
                {
                    break;
                }
            }

            if (this.pathFound)
            {
                Console.WriteLine("The shortest path between cells is " + (this.currentNumber + 1));
            }
            else
            {
                Console.WriteLine("End unreachable cells!");
            }

            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (this.Lab[i, j] == "0")
                    {
                        this.Lab[i, j] = "u";
                    }
                }
            }
        }

        private void GenerateLabyrinth()
        {
            var cellContent = "00X";

            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    this.Lab[i, j] = cellContent[Rand.Next(0, 3)].ToString();
                }
            }
        }

        private void SetStartAndEnd(string[,] lab)
        {
            lab[this.startCoordinates[0], this.startCoordinates[1]] = "S";
            lab[this.endCoordinates[0], this.endCoordinates[1]] = "E";
        }
    }
}