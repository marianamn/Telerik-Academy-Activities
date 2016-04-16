/* Problem 9. Play with Int, Double and String
• Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. 
◦ If the variable is  int  or  double , the program increases it by one.
◦ If the variable is a  string , the program appends  *  at the end.

• Print the result at the console. Use switch statement. */

using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        string command = Console.ReadLine();
        string option = Console.ReadLine();
        
        switch (command)
        {
            case "integer": int resultedInt = int.Parse(option) + 1;
                Console.WriteLine(resultedInt);
                break;
            case "real":
                double resultedReal = double.Parse(option) + 1;
                Console.WriteLine("{0:F2}", resultedReal);
                break;
            case "text":
                string resultedString = option + "*";
                Console.WriteLine(resultedString);
                break;
        }
    }
}

//using System;
//class PlayWithIntDoubleAndString
//{
//    static void Main()
//    {
//        Console.Write("Chose an option: 1 - for int; 2- for double and 3 - for string \n");
//        int option = int.Parse(Console.ReadLine());
//
//        switch (option)
//        {
//            case 1: Console.Write("Enter an int number: "); break;
//            case 2: Console.Write("Enter a double number: "); break;
//            case 3: Console.Write("Enter a string: "); break;
//            default: Console.Write("Incorrect option!"); break;
//        }
//
//        if (option == 1)
//        {
//            int numberInt = int.Parse(Console.ReadLine());
//            ++numberInt;
//            Console.WriteLine(numberInt);
//        }
//        else
//        {
//            if (option == 2)
//            {
//                double numberDouble = double.Parse(Console.ReadLine());
//                ++numberDouble;
//                Console.WriteLine(numberDouble);
//            }
//            else
//            {
//                string text = Console.ReadLine();
//                Console.WriteLine(text + "*");
//            }
//        }
//    }
//}

