/*Problem 9. Exchange Variable Values
• Declare two integer variables  a  and  b  and assign them with  5  and  10  
and after that exchange their values by using some programming logic.
• Print the variable values before and after the exchange.*/

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The initial value of \"a\" is: {0}", a);
        Console.WriteLine("The initial value of \"b\" is: {0}", b);
        
        
        int newB = b;
        b = a;
        a = newB;
        Console.WriteLine("The value of \"a\" after exchange is: {0}", a);
        Console.WriteLine("The value of \"b\" after exchange is: {0}", b);
        
    }
}