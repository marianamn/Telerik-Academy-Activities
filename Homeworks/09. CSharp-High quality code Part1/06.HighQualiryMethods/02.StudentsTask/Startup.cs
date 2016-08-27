using System;

namespace _02.StudentsTask
{
    public class Startup
    {
        public static void Main()
        {
            Student firstStudent = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            firstStudent.BirthDate = "From Sofia, born at 17.03.1992";

            Student secondStudent = new Student() { FirstName = "Stella", LastName = "Markova" };
            secondStudent.BirthDate = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine(
                "{0} older than {1} -> {2}", 
                firstStudent.FirstName, 
                secondStudent.FirstName, 
                firstStudent.CheckIsStudentOlderThan(secondStudent));
        }
    }
}
