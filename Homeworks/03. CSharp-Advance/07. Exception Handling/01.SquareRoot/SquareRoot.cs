namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    double sqr = Math.Sqrt(number);

                    Console.WriteLine("{0:F3}", sqr);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }       
        }
    }
}
