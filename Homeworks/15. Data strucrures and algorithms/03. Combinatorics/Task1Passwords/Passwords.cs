namespace Task1Passwords
{
    using System;

    public class Passwords
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var n = input.Length;
            char star = '*';

            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == star)
                {
                    count++;
                }
            }

            long result = 1;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    result *= 2;
                }  
            }
            else
            {
                result = 1;
            }

            Console.WriteLine(result);
        }
    }
}