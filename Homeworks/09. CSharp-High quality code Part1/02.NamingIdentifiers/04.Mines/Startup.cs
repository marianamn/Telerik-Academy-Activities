namespace _04.Mines
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const int MaxScore = 35;
        private const int NumberOfTopPlayers = 6;

        public static void Main()
        {
            string command = string.Empty;

            GameLogic game = new GameLogic();

            char[,] playfield = game.CreatePlayField();
            char[,] createBombs = game.CreateBombs();
            int counter = 0;
            bool stepOnBomb = false;
            List<Points> topPlayers = new List<Points>(NumberOfTopPlayers);
            int row = 0;
            int column = 0;
            bool inGame = true;
            bool maxResultAchievd = false;

            do
            {
                if (inGame)
                {
                    Console.WriteLine(
                        "Lets play MinesWeeper!\n" +
                        "Try your luck to find all the fields without mines.\n" +
                        "Commands:\n" +
                        "'Top' - shows ranking\n" +
                        "'Restart' - begins new Game\n" +
                        "'Exit' - exit the Game");

                    game.CreateBorders(playfield);
                    inGame = false;
                }

                Console.Write("Enter row and column: ");

                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playfield.GetLength(0) && column <= playfield.GetLength(1))
                    {
                        command = "Turn";
                    }
                }

                switch (command)
                {
                    case "Top":
                        game.RankList(topPlayers);
                        break;
                    case "Restart":
                        playfield = game.CreatePlayField();
                        createBombs = game.CreateBombs();
                        game.CreateBorders(playfield);
                        stepOnBomb = false;
                        inGame = false;
                        break;
                    case "Exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "Turn":
                        if (createBombs[row, column] != '*')
                        {
                            if (createBombs[row, column] == '-')
                            {
                                game.MoveNext(playfield, createBombs, row, column);
                                counter++;
                            }

                            if (MaxScore == counter)
                            {
                                maxResultAchievd = true;
                            }
                            else
                            {
                                game.CreateBorders(playfield);
                            }
                        }
                        else
                        {
                            stepOnBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Exception: Invalid command");
                        break;
                }

                if (stepOnBomb)
                {
                    game.CreateBorders(createBombs);
                    Console.Write("\nYou steped on mine! Your score is {0} points. Enter your nick name: ", counter);
                    string playerNickName = Console.ReadLine();
                    Points playerPoints = new Points(playerNickName, counter);

                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(playerPoints);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].UserPoints < playerPoints.UserPoints)
                            {
                                topPlayers.Insert(i, playerPoints);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Points x, Points y) => y.UserName.CompareTo(x.UserName));
                    topPlayers.Sort((Points x, Points y) => y.UserPoints.CompareTo(x.UserPoints));
                    game.RankList(topPlayers);

                    playfield = game.CreatePlayField();
                    createBombs = game.CreateBombs();
                    counter = 0;
                    stepOnBomb = false;
                    inGame = true;
                }

                if (maxResultAchievd)
                {
                    Console.WriteLine("\nWell done! You have made 35 steps without stepping a mine!");
                    game.CreateBorders(createBombs);
                    Console.WriteLine("Enter your nick name: ");
                    string playerNickName = Console.ReadLine();
                    Points playerPoints = new Points(playerNickName, counter);
                    topPlayers.Add(playerPoints);
                    game.RankList(topPlayers);
                    playfield = game.CreatePlayField();
                    createBombs = game.CreateBombs();
                    counter = 0;
                    maxResultAchievd = false;
                    inGame = true;
                }
            }
            while (command != "Exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("2015");
            Console.Read();
        }
    }
}
