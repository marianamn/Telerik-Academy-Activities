/*Problem 15.* Age after 10 Years
• Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        int myAge = 0;

        bool IsMyBirthdayMonthPassed = birthDate.Month < currentDate.Month;
        bool IsTheCurrentMonthMyBirthdayMonth = birthDate.Month == currentDate.Month;
        bool IsMyBirthdaySmaller = birthDate.Day <= currentDate.Day;
        bool IsMyBirthdayPassed = (IsMyBirthdayMonthPassed || (IsTheCurrentMonthMyBirthdayMonth && IsMyBirthdaySmaller));

        if (IsMyBirthdayPassed)
        {
            myAge = (int)(currentDate.Year - birthDate.Year);
        }
        else
        {
            myAge = (int)((currentDate.Year - birthDate.Year) - 1);
        }

        Console.WriteLine(myAge);
        Console.WriteLine(myAge + 10);
    }
}