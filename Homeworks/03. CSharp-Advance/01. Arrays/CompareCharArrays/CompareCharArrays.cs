/*Problem 3. Compare char arrays
 • Write a program that compares two char arrays lexicographically (letter by letter).
   On the first line you will receive the first char array as a string
   On the second line you will receive the second char array as a string

   Print < if the first array is lexicographically smaller
   Print > if the second array is lexicographically smaller
   Print = if the arrays are equal

    Input	Output
    hello
    halo	 >
    food
    food	 =
 */


using System;
class CompareArrays
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        char[] firstCharArray = new char[firstLine.Length];

        for (int i = 0; i < firstLine.Length; i++)
        {
            firstCharArray[i] = firstLine[i];
        }

        string secondLine = Console.ReadLine();
        char[] secondCharArray = new char[secondLine.Length];

        for (int i = 0; i < secondLine.Length; i++)
        {
            secondCharArray[i] = secondLine[i];
        }

        for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
        {
            if (firstCharArray[i] - '0' > secondCharArray[i] - '0')
            {
                Console.WriteLine(">");
                Environment.Exit(0);
                break;
            }
            else if (firstCharArray[i] - '0' < secondCharArray[i] - '0')
            {
                Console.WriteLine("<");
                Environment.Exit(0);
                break;
            }
        }
        if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine(">");
        }
        else if (firstCharArray.Length < secondCharArray.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}

///more UI specified solution

//using System;
//class CompareArrays
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter first array lenght: ");
//        int n = int.Parse(Console.ReadLine());
//        char[] firstArray = new char[n];
//
//
//        Console.WriteLine("Enter second array lenght: ");
//        int m = int.Parse(Console.ReadLine());
//        char[] secondArray = new char[m];
//
//        Console.WriteLine("Enter first char array: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("first array[{0}] = ", i);
//            firstArray[i] = char.Parse(Console.ReadLine());
//        }
//
//
//        Console.WriteLine("Enter second char array: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("first array[{0}] = ", i);
//            secondArray[i] = char.Parse(Console.ReadLine());
//        }
//
//        if (n != m)
//        {
//            Console.WriteLine("First array is not equal to second array.");
//        }
//        else
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (firstArray[i] == secondArray[i])
//                {
//                    Console.WriteLine("first array [{0}] is equal to second array [{0}]", i);
//                }
//                else
//                {
//                    Console.WriteLine("first array [{0}] is not equal to second array [{0}]", i);
//                }
//            }
//        }
//    }
//}