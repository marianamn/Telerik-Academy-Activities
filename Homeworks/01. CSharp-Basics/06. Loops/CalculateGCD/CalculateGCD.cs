/*Problem 17.* Calculate GCD
• Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b.
• Use the Euclidean algorithm (find it in Internet).

Examples:
a     b    GCD(a, b)
3     2    1 
60    40   20 
5     -15  5                */

using System;

class CalculateGCD
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = Math.Abs(int.Parse(input[0]));
        int b = Math.Abs(int.Parse(input[1]));

        int reminder = GCD(a, b);

        Console.WriteLine(reminder);
    }

    static int GCD(int a, int b)
    {
        int remainder;

        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}

//using System;

//class CalculateGCD
//{
//    static void Main()
//    {
//        //Formal description of the Euclidean algorithm
//        //•Input Two positive integers, a and b. 
//        //•Output The greatest common divisor, g, of a and b. 
//        //•Internal computation
//        //1.If a<b, exchange a and b. 
//        //2.Divide a by b and get the remainder, r. If r=0, report b as the GCD of a and b. 
//        //3.Replace a by b and replace b by r. Return to the previous step. 
//
//        string[] input = Console.ReadLine().Split(' ');
//        int a = int.Parse(input[0]);
//        int b = int.Parse(input[1]);
//
//        if (a < b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }
//
//        int reminder = a % b;
//
//        while (reminder != 0)
//        {
//            a = b;
//            b = reminder;
//            reminder = a % b;
//        }
//
//        Console.WriteLine(b);
//    }
//}

