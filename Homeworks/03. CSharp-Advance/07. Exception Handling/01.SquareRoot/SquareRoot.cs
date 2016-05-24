namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                double sqr = Math.Sqrt(number);

                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:F3}", sqr);
                }
            }
            catch (Exception ex)
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
