/*Problem 2. Float or Double?
• Which of the following values can be assigned to a variable of type  float  
 and which to a variable of type  double :  34.567839023, 12.345, 8923.1234857, 3456.091 ?
• Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/


using System;
class FloatOrDouble
{
    static void Main()
    {
        float firstNumber = 12.345f;
        float secondNumber = 3456.091f;
        double thirdNumber = 8923.1234857;
        double fourthNumber = 34.567839023;
        Console.WriteLine("For number {0} we can use float type", firstNumber);
        Console.WriteLine("For number {0} we can use float type", secondNumber);
        Console.WriteLine("For number {0} we can use double type", thirdNumber);
        Console.WriteLine("For number {0} we can use double type", fourthNumber);
    }
}