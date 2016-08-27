using System;

namespace _04.ExamTaskFeathers
{
    public class Feathers
    {
        private const long MagicNumberForEven = 123123123123;
        private const long MagicNumberForOdd = 317;

        public static void Main()
        {
            long birds = long.Parse(Console.ReadLine());
            long feathers = long.Parse(Console.ReadLine());

            double avrg = (double)feathers / birds;

            double result = 0;

            if (birds == 0)
            {
                Console.WriteLine("{0:F4}", birds);
            }
            else if (birds % 2 == 0)
            {
                double reminder = avrg % 10;
                result = avrg * (double)MagicNumberForEven;
                Console.WriteLine("{0:F4}", result);
            }
            else
            {
                result = avrg / MagicNumberForOdd;
                Console.WriteLine("{0:F4}", result);
            }
        }
    }
}