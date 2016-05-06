/*Problem 12. Index of letters
• Write a program that creates an array containing all letters from the alphabet ( a-z ).
• Read a word from the console and print the index of each of its letters in the array. */

using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 97); //65 is the offset for capital A in the ascii table
        }
        
        string wordIput = Console.ReadLine().ToLower();
       
        for (int i = 0; i < wordIput.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (wordIput[i] == letters[j])
                {
                    Console.WriteLine("{0}", j);
                }
            }
        }
    }
}


///more UI specified solution
///
//using System;
//class IndexOfLetters
//{
//    static void Main()
//    {
//        char[] letters = new char[26];
//
//        for (int i = 0; i < 26; i++)
//        {
//            letters[i] = (char)(i + 65); //65 is the offset for capital A in the ascii table
//        }
//
//        Console.WriteLine("Enter word with capital letters:");
//        string wordIput = Console.ReadLine().ToUpper();
//
//        for (int i = 0; i < wordIput.Length; i++)
//        {
//            for (int j = 0; j < letters.Length; j++)
//            {
//                if (wordIput[i] == letters[j])
//                {
//                    Console.WriteLine("Letter={0} --> Index={1}", letters[j], Convert.ToInt32(wordIput[i]));
//                }
//
//            }
//        }
//    }
//}