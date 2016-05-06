/*Problem 8. Number as array
• Write a method that adds two positive integer numbers represented as arrays of digits 
 (each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ).
• Each of the numbers that will be added could have up to  10 000  digits. */


using System;
using System.Linq;
class NumberAsArray
{
    static void Main() 
     { 
         Console.WriteLine("Enter first integer number: "); 
         string input1 = Console.ReadLine(); 
 
 
         Console.WriteLine("Enter second integer number: "); 
         string input2 = Console.ReadLine(); 
 
         // Check the lengths, if one of them is bigger than other => add zeroes to smaller length
         int numLenght = 0;
         if (input1.Length > input2.Length)
         {
             numLenght = input1.Length;
         }
         else
         {
             numLenght = input2.Length;
         }
         input1 = input1.PadLeft(numLenght, '0');
         input2 = input2.PadLeft(numLenght, '0');


         CreateArrayNumber(input1);
         CreateArrayNumber(input2); 

         //check if number lenght is les than 10000 digits
         if (numLenght>10000)
         {
             Console.WriteLine("Invalid Input!");
         }
         else
         {
             SumOfTwoArrays(CreateArrayNumber(input1), CreateArrayNumber(input2));
             PrintTheNumber(SumOfTwoArrays(CreateArrayNumber(input1), CreateArrayNumber(input2)));
             Console.WriteLine(); 
         }
         
     } 
     static int[] CreateArrayNumber(string input) 
     { 
         int[] number = new int[input.Length]; 
 
         for (int i = 0; i < number.Length; i++) 
         { 
             number[i] = int.Parse(input[input.Length - 1 - i].ToString()); 
         } 
         return number; 
    } 
     
    static void PrintTheNumber(string number) 
     { 
         Console.WriteLine("The summed number is: "); 
         for (int i = number.Length - 1; i >= 0; i--) 
         { 
             Console.Write(number[i]); 
         } 
     } 
     
    static string SumOfTwoArrays(int[] numberOne, int[] numberTwo) 
     { 
         if (numberOne.Length > numberTwo.Length) 
         {
             return SumOfTwoArrays(numberTwo, numberOne); 
         } 
 
 
         string summedNumber = string.Empty; 
         int rest = 0; 
          
         for (int i = 0; i < numberTwo.Length ; i++) 
         { 
            summedNumber += ((numberOne[i] + numberTwo[i]) % 10 + rest).ToString(); 
             rest = (numberOne[i] + numberTwo[i]) / 10; 
            if (rest > 0 && i == numberTwo.Length - 1) 
             { 
                 summedNumber += rest; 
             }                
         }         
         return summedNumber; 
     } 
      
 } 
