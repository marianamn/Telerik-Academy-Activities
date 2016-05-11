namespace _03.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            DateTime today = DateTime.Today;

            Console.WriteLine("Today is {0}.", today.DayOfWeek);
        }
    }
}
