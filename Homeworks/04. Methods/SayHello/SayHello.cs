/*Problem 1. Say Hello
• Write a method that asks the user for his name and prints  “Hello, <name>”  
• Write a program to test this method.

Example:
input                output
Peter                Hello, Peter! */

using System;
using System.Linq;
class SayHello
{
    static void Main()
    {
        string name = AskName();
        CheckName(name);
    }

    static string AskName()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    //check if the string consist of letters
    static void CheckName(string input)
    {
        bool isLetter = input.All(char.IsLetter);
        if (isLetter)
        {
            Console.WriteLine("Hello, {0}!", input);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

}
