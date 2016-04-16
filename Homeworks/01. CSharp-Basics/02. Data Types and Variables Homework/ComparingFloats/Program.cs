/*Problem 13.* Comparing Floats
• Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001.
Note: Two floating-point numbers  a  and  b  cannot be compared directly by  a == b  because of the nature of
the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant  eps.

 Example: a=5.3;         b=6.01;            False ---The difference of 0.71 is too big (> eps)
 Example: a=5.00000001;  b=5.00000003;      true  --- The difference 0.00000002 < eps
 Example: a=5.00000005;  b=5.00000001;      true ---The difference 0.00000004 < eps
 Example: a=-0.0000007;  b=0.00000007;      true ---The difference 0.00000077 < eps
 Example: a=-4.999999;   b=-4.999998;       False ---Border case. The difference 0.000001 == eps. We consider the numbers are different.
 Example: a=4.999999;    b=4.999998;        False ---Border case. The difference 0.000001 == eps. We consider the numbers are different.
 */

using System;

class ComparingFloats
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        decimal difference = (decimal)Math.Round(Math.Abs(a - b), 7);

        bool result = difference < 0.000001m;

        if (result)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}