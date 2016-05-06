/*Problem 13. Solve tasks
• Write a program that can solve these tasks: 
◦ Reverses the digits of a number
◦ Calculates the average of a sequence of integers
◦ Solves a linear equation  a * x + b = 0  

• Create appropriate methods.
• Provide a simple text-based menu for the user to choose which task to solve.
• Validate the input data: 
◦ The decimal number should be non-negative
◦ The sequence should not be empty
◦  a  should not be equal to  0  
*/


using System;
using System.Linq;


namespace SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine("Chose number for task: \n1 - Reverse digits; \n2 - Average of a sequence; \n3 - Linear equation;");
            int task = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch (task)
            {
                case 1: 
                    Console.WriteLine("Enter number:");
                    decimal number = decimal.Parse(Console.ReadLine());
                    if (number<0)
                    {
                        Console.WriteLine("Invalid input! Please enter positive number");
                    }
                    else
                    {
                        Console.WriteLine(ReverseDigits(number)); 
                    }
                    break;
                

                case 2: 
                    Console.WriteLine("Enter number sequence, separated by commas and space:");
                    string input = Console.ReadLine();
                    string[] numbers = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                    int[] array = new int[numbers.Length];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                       array[i] = int.Parse(numbers[i]);
                    }

                    if (array.Length < 0)
                    {
                        Console.WriteLine("Invalid input! You should enter at least one number in array!");
                    }
                    else
                    {
                        AverageOfASequence(array.Length, array); 
                    }
                    break;


                case 3:
                    Console.WriteLine("Enter number a:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number b:");
                    double b = double.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("Invalid input! Number a should be gteater than 0");
                    }
                    else
                    {
                        Console.WriteLine("Linear equation a * x + b = 0");
                        Console.WriteLine("x={0}", LinearEquation(a, b));
                    }
                    break;
                
                default: Console.WriteLine("Invalid input!"); break;
            }
        }

      
        static string ReverseDigits(decimal num)
        {
            string array = "";
            while ((num / 10) > 0)
            {
                decimal lastDig = num % 10;
                array = array + lastDig + "";
                num = Math.Floor(num / 10);
                if (num == 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return array;
        }


        static void AverageOfASequence(int n, int[] array)
        {
            double avarage = array.Average();
            Console.WriteLine("Average of the array is {0}", avarage);
        }


        static double LinearEquation(double a, double b)
        {
            double x = -b / a;
            return x;
        }
    }
}
