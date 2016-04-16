/*Problem 6. Strings and Objects
• Declare two string variables and assign them with  Hello  and  World .
• Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
• Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

using System;

class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string greetingWho = "World";
        object greetingSentence = greeting + " " + greetingWho;
        string wholeGreetingSentence = greetingSentence.ToString();
        Console.WriteLine(wholeGreetingSentence);
    }
}