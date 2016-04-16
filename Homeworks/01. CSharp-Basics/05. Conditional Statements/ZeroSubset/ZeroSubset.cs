/*Problem 12.* Zero Subset
• We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
• Assume that repeating the same subset several times is not a problem.

Examples:
numbers            result
3 -2 1 1 8         -2 + 1 + 1 = 0 
3 1 -7 35 22       no zero subset   
1 3 -4 -2 -1       1 + -1 = 0 
                   1 + 3 + -4 = 0 
                   3 + -2 + -1 = 0 
1 1 1 -1 -1        1 + -1 = 0 
                   1 + 1 + -1 + -1 = 0   
0 0 0 0 0          0 + 0 + 0 + 0 + 0 = 0 

Hint: you may check for zero each of the 31 subsets with 31  if  statements.*/


using System;
class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Entered 5 numbers in a single line, separated by a space");
        string input = Console.ReadLine();
        string[] fiveNumbers = input.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

        if (fiveNumbers.Length < 5)
        {
            Console.WriteLine("Invalid input!");
        }
        
        int a = int.Parse(fiveNumbers[0]);
        int b = int.Parse(fiveNumbers[1]);
        int c = int.Parse(fiveNumbers[2]);
        int d = int.Parse(fiveNumbers[3]);
        int e = int.Parse(fiveNumbers[4]);

        int sumAB = a + b;
        int sumAC = a + c;
        int sumAD = a + d;
        int sumAE = a + e;
        int sumBC = b + c;
        int sumBD = b + d;
        int sumBE = b + e;
        int sumCD = c + d;
        int sumCE = c + e;
        int sumDE = d + e;
        int sumABC = sumAB + c;
        int sumABD = sumAB + d;
        int sumABE = sumAB + e;
        int sumBCD = sumBC + d;
        int sumBDE = sumBD + e;
        int sumCDE = sumCD + e;
        int sumABCD = sumABC + d;
        int sumABDE = sumABD + e;
        int sumBCDE = sumBCD + e;
        int sumAllNumber = a + b + c + d + e;

        bool zeroSubset = sumAB != 0 && sumAC != 0 && sumAD != 0 && sumAE != 0 && sumBC != 0 && sumBD != 0 && sumBE != 0 &&
            sumCD != 0 && sumCE != 0 && sumDE != 0 && sumABC != 0 && sumABD != 0 && sumABE != 0 && sumBCD != 0 && sumBDE != 0 &&
            sumCDE != 0 && sumABCD != 0 && sumABDE != 0 && sumBCDE != 0 && sumAllNumber != 0;

        if (zeroSubset)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            if (sumAB == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, sumAB);
            }
            if (sumAC == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, c, sumAC);
            }
            if (sumAD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, d, sumAD);
            }
            if (sumAE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, e, sumAE);
            }
            if (sumBC == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, c, sumBC);
            }
            if (sumBD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, d, sumBD);
            }
            if (sumBE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, e, sumBE);
            }
            if (sumCD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, d, sumCD);
            }
            if (sumCE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, e, sumCE);
            }
            if (sumDE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", d, e, sumDE);
            }
            if (sumABC == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sumABC);
            }
            if (sumABD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, sumABD);
            }
            if (sumABE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, sumABE);
            }
            if (sumBCD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, sumBCD);
            }
            if (sumBDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, d, e, sumBDE);
            }
            if (sumCDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumCDE);
            }
            if (sumABCD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, sumABCD);
            }
            if (sumABDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, sumABDE);
            }
            if (sumBCDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumBCDE);
            }
            if (sumAllNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, sumAllNumber);
            }
        }
    }
}