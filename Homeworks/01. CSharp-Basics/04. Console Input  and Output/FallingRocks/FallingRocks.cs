/*Problem 12.** Falling Rocks
 • Implement the "Falling Rocks" game in the text console. 
   ◦ A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
   ◦ A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
   ◦ Rocks are the symbols  ^, @, *, &, +, %, $, #, !, ., ;, -  distributed with appropriate density. 
     The dwarf is  (O).
• Ensure a constant game speed by  Thread.Sleep(150) .
• Implement collision detection and scoring system.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Rocks
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;

    public int Count { get; set; }
}
class FallingRocks
{
    private static int rock;
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {

        int playfield = 41;
        byte livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 70;
        Rocks dwarf = new Rocks();
        dwarf.x = 20;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = 'O';
        dwarf.color = ConsoleColor.Gray;
        Random randomGenerator = new Random();
        List<Rocks> fallingRocks = new List<Rocks>();
        


        while (true)
        {
            {
                Random colorRandom = new Random(); 
                ConsoleColor[] color = new ConsoleColor[8] { ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkCyan }; 
                Random symbolRandom = new Random();
                char[] symbol = new char[11] { '!', '@', '#', '$', '%', '^', '&', '*', '+', '.', ';'}; 
                char newSymbol = symbol[symbolRandom.Next(0, 11)]; 

                Rocks newRock = new Rocks();
                newRock.color = color[colorRandom.Next(0, 8)]; 
                newRock.x = randomGenerator.Next(0, playfield);
                newRock.y = 0;
                newRock.c = symbol[symbolRandom.Next(0, 11)]; 
                fallingRocks.Add(newRock);
            }


            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfield)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            List<Rocks> newList = new List<Rocks>();
            for (int i = 0; i < fallingRocks.Count; i++)
            {
                Rocks oldRock = fallingRocks[i];
                Rocks newRock = new Rocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                if (newRock.y == dwarf.y && newRock.x == dwarf.x)
                {
                    livesCount--;
                    PrintStringOnPosition(dwarf.x, dwarf.y, "X", ConsoleColor.Red);
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(43, 10, "GAME OVER!", ConsoleColor.Red);
                        PrintStringOnPosition(43, 12, "Press Enter to exit...", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }

            }
            fallingRocks = newList;
            Console.Clear();

            PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            foreach (Rocks rock in fallingRocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
            }

            PrintStringOnPosition(43, 4, "Lives:" + livesCount, ConsoleColor.Blue);
            Thread.Sleep(500);
        }
    }
}



    