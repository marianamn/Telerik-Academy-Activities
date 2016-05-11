namespace _01.LeapYear
{
    using System;

    public class LeapYear
    {
        public static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
