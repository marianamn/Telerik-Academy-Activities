using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Workdays
{
    class Workdays
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DateTime todayDate = new DateTime();
            todayDate = DateTime.Now.Date;
            Console.WriteLine("Today is {0:MM.dd.yyyy}", todayDate);

            Console.WriteLine("Enter date in format MM.dd.yyyy:");
            string inputDate = (Console.ReadLine());
            DateTime endDate = Convert.ToDateTime(inputDate);


            Console.WriteLine("Number of workdays between {0:MM.dd.yyyy} and {1:MM.dd.yyyy} is {2}",
                              todayDate, endDate, WorkdaysCount(todayDate, endDate));

        }
        static int WorkdaysCount(DateTime today, DateTime endDate)
        {
            int count = 0;
            while (today <= endDate)
            {
                if (today.DayOfWeek != DayOfWeek.Sunday &&
                    today.DayOfWeek != DayOfWeek.Saturday &&
                    TodayisHoliday(today) == false)
                {
                    count++;
                }
                today = today.AddDays(1);
            }
            return count;
        }


        static bool TodayisHoliday(DateTime date)
        {
            bool isHoliday = true;
            DateTime[] publicHolidays = { new DateTime(2015,03,03),
                                          new DateTime(2015,05,06),
                                          new DateTime(2015,09,22),
                                          new DateTime(2015,12,24) };

            for (int i = 0; i < publicHolidays.Length; i++)
            {
                if (date == publicHolidays[i])
                {
                    isHoliday = true;
                }
                else
                {
                    isHoliday = false;
                }
            }
            return isHoliday;
        }

    }
}
