namespace _03_05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Anton", "Ivanov", 17),
                new Student("Petar", "Filipov", 20),
                new Student("Maria", "Nikolova", 25),
                new Student("Pavel", "Simeonov", 19),
                new Student("Pavel", "Dimitrov", 23),
                new Student("Nadia", "Trifonova", 22)
            };

            Console.WriteLine("Initial lit of students:");
            PrintStudents(students);
            Console.WriteLine();

            // task 3
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            var result = students.Where(x => x.FirstName.CompareTo(x.LastName) == -1);
            PrintStudents(result);
            Console.WriteLine();

            // task 4
            Console.WriteLine("Students with age between 18 and 24:");
            var studentsInGivenAgeRange = students.Where(x => x.Age >= 18 && x.Age >= 24);
            PrintStudents(studentsInGivenAgeRange);
            Console.WriteLine();

            // task 5
            Console.WriteLine("Students sorted in descending order using lambda extension methods:");
            var sortedStudents = students.OrderByDescending(x => x.FirstName)
                                         .ThenByDescending(x => x.LastName);
            PrintStudents(sortedStudents);
            Console.WriteLine();

            // task 5 - with LINQ
            Console.WriteLine("Students sorted in descending order using LINQ:");
            var sortedStudentsWithLINQ = from student in students
                                          orderby student.FirstName descending,
                                          student.LastName descending
                                          select student;
            PrintStudents(sortedStudents);
            Console.WriteLine();
        }

        private static void PrintStudents<T>(IEnumerable<T> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
