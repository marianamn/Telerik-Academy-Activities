namespace _02.RandomNumbers
{
    using System;

    public class RandomNumbers
    {
        public static void Main()
        {
            Random generator = new Random();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Random number{0} = {1}", i, generator.Next(100, 201));
            }
        }
    }
}
