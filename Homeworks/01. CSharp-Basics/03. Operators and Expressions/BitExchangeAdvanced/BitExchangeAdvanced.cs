/*Problem 16.** Bit Exchange (Advanced)
• Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
• The first and the second sequence of bits may not overlap.

Examples:
n             p   q    k    binary representation of n              binary result                             result
1140867093    3   24   3    01000100 00000000 01000000 00010101     01000010 00000000 01000000 00100101       1107312677 
4294901775    24  3    3    11111111 11111111 00000000 00001111     11111001 11111111 00000000 00111111       4194238527 
2369124121    2   22   10   10001101 00110101 11110111 00011001     01110001 10110101 11111000 11010001       1907751121 
987654321     2   8    11   -                                       -                                         overlapping 
123456789     26  0    7    -                                       -                                         out of range 
33333333333   -1  0    33   -                                       -                                         out of range   */


using System;

class BitExchangeAdvanced
{
    static void Main()
    {
         uint number = uint.Parse(Console.ReadLine()); 
         int p = int.Parse(Console.ReadLine()); 
         int q = int.Parse(Console.ReadLine()); 
         int k = int.Parse(Console.ReadLine()); 

         for (int i = 0; i <= (k - 1); i++) 
         { 
             if (((number >> p) & 1) != ((number >> q) & 1)) 
             { 
                 number = number ^ (1u << p); 
                 number = number ^ (1u << q); 
             } 
             p++; 
             q++; 
         } 
 
         Console.WriteLine(number); 
     }
} 


//using System;
//
//class BitExchangeAdvanced
//{
//    static void Main()
//    {
//        Console.WriteLine("Type positive number: ");
//        uint number = uint.Parse(Console.ReadLine());
//
//
//        Console.WriteLine("Type bit to exchange p: ");
//        int p = int.Parse(Console.ReadLine());
//
//
//        Console.WriteLine("Type bit to exchange q: ");
//        int q = int.Parse(Console.ReadLine());
//
//
//        Console.WriteLine("Type counter k:");
//        int k = int.Parse(Console.ReadLine());
//
//
//        // Check if the sequences are more then 31 bits 
//        if (((p + (k - 1)) >= 32) || ((q + (k - 1)) >= 32))
//        {
//            Console.WriteLine("Out of range");
//            System.Environment.Exit(0);
//        }
//        // Check if sequences overlapping 
//        else if (((q >= p) && (q <= (p + (k - 1)))) || ((p >= q) && (p <= (q + (k - 1)))))
//        {
//            Console.WriteLine("Overlapping");
//            System.Environment.Exit(0);
//        }
//
//        Console.WriteLine("Number binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
//
//        // Exchange bits 
//        for (int i = 0; i <= (k - 1); i++)
//        {
//            if (((number >> p) & 1) != ((number >> q) & 1))
//            {
//                number = number ^ (1u << p);
//                number = number ^ (1u << q);
//            }
//            p++;
//            q++;
//        }
//
//
//        Console.WriteLine("Binary result: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
//        Console.WriteLine("Result: {0}", number);
//    }
//}
