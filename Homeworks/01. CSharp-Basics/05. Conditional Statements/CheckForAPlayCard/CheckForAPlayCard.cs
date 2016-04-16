/*Problem 3. Check for a Play Card
 • Classical play cards use the following signs to designate the card face: 
  `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” 
  if it is a valid card sign or “no” otherwise. 
 
Examples:
character    Valid card sign?
5            yes 
1            no 
Q            yes 
q            no 
P            no 
10           yes 
500          no                  */ 

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        if (Array.IndexOf(cards, input) >= 0)
        {
            Console.WriteLine("yes {0}", input);
        }
        else
        {
            Console.WriteLine("no {0}", input);
        }
    }
}