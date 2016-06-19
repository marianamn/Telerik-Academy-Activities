namespace _03.RangeExceptions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] numbers = { 4, 30, 100, 120 };

            foreach (var number in numbers)
            {
                try
                {
                    if (number < 0 || number > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }

                    Console.WriteLine("Number {0} is in range [0,100]", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("Number {0} {1}", number, ex.Message);
                }
            }

            Console.WriteLine();
            
            List<DateTime> dates = new List<DateTime>
            {
                new DateTime(2008, 12, 31),
                new DateTime(1979, 02, 25),
                new DateTime(2001, 11, 05),
                new DateTime(2008, 12, 31),
                new DateTime(2008, 12, 31)
            };

            DateTime startDate = new DateTime(1980, 01, 01);
            DateTime endDate = new DateTime(2013, 12, 31);

            foreach (var date in dates)
            {
                try
                {
                    if (date < new DateTime(1980, 01, 01) || date > new DateTime(2013, 12, 31))
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }

                    Console.WriteLine("Date {0:MM.dd.yyyy} is in range [{1:MM.dd.yyyy} - {2:MM.dd.yyyy}]", date, startDate, endDate);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("Date {0:MM.dd.yyyy} {1}", date, ex.Message);
                }
            }

            Console.WriteLine();
        }
    }
}