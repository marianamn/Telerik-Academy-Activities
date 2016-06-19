namespace _09_19.ExtractStudentsInfo
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
                new Student("Gero", "Goshev", 12106, "0899556897", "gero@abv.bg", new List<double> { 2, 6 }, 3),
                new Student("Pesho", "Peev", 45155, "+359256565", "pesho@abv.com", new List<double> { 5, 2 }, 2),
                new Student("Niki", "Kolev", 11106, "088565675", "niki@abv.bg", new List<double> { 3, 4.40, 5 }, 1),
                new Student("Ani", "Vasileva", 34111, "088845635", "ani@mail.bg", new List<double> { 3.20, 4 }, 2),
                new Student("Mimi", "Pavlova", 15103, "028562375", "mimia@abv.bg", new List<double> { 3, 4.30 }, 1),
            };

            Console.WriteLine("Students Initial List:");
            Print(students);
            Console.WriteLine();

            // task 9
            Console.WriteLine("Students that are from group number 2 with LINQ query:");
            var studentdInGroup = from student in students
                                  where student.GroupNumber == 2
                                  select student;
            Print(studentdInGroup);
            Console.WriteLine();

            // task 10
            Console.WriteLine("Students that are from group number 2 with with extension methods:");
            var studentdInGroupWithExtension = students.Where(x => x.GroupNumber == 2);
            Print(studentdInGroupWithExtension);
            Console.WriteLine();

            // task 11
            Console.WriteLine("Students that have email in abv.bg with LINQ:");
            var studentsWithAbvEmail = from student in students
                                       where student.Email.EndsWith("abv.bg")
                                       select student;
            Print(studentsWithAbvEmail);
            Console.WriteLine();

            // task 12
            Console.WriteLine("Students with phones in Sofia using LINQ:");
            var studentsWithPhoneInSofia = from student in students
                                           where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592")
                                           select student;
            Print(studentsWithPhoneInSofia);
            Console.WriteLine();

            // task 13
            Console.WriteLine("Students that have at least one mark Excellent (6) using LINQ:");
            var studentsWithExcellentMark = from student in students
                                            where student.Marks.Contains(6)
                                            select new
                                            {
                                                name = student.FirstName + " " + student.LastName,
                                                marks = student.Marks
                                            };

            foreach (var student in studentsWithExcellentMark)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("{0}, marks:{1}", student.name, string.Join(", ", student.marks));
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            // task 14
            Console.WriteLine("Students that have at least one mark 2 using extension methods:");
            var studentsWithWeekMarks = students.Where(x => x.Marks.Contains(2));
            Print(studentsWithWeekMarks);

            // task 15
            Console.WriteLine("Students that enrolled in 2006:");
            var studentsFrom2006 = from student in students
                                   where student.FacNumber % 100 == 06
                                   select new
                                   {
                                       name = student.FirstName + " " + student.LastName,
                                       marks = student.Marks
                                   };

            foreach (var student in studentsFrom2006)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("{0}, marks:{1}", student.name, string.Join(", ", student.marks));
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            // task 16
            List<string> departments = new List<string> { "Literature", "Mathematics", "IT" };

            List<Group> groups = new List<Group> { new Group(1, departments[0]), new Group(2, departments[1]), new Group(3, departments[2]) };

            Console.WriteLine("Students from Mathematics department:");
            var studentsFromMathDept = from certianGroup in groups
                                       where certianGroup.GroupNumber == 2
                                       join student in students on certianGroup.GroupNumber equals student.GroupNumber
                                       select new
                                       {
                                           name = student.FirstName + " " + student.LastName,
                                           depatrment = certianGroup.DepartmentName
                                       };

            foreach (var student in studentsFromMathDept)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("{0}, department:{1}", student.name, string.Join(", ", student.depatrment));
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            // task 17
            var largestString = (from dept in departments
                                select dept)
                                .Max();

            Console.WriteLine("Departments array: {0}", string.Join(", ", departments));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("It's largest string is: {0}", largestString);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            // task 18
            Console.WriteLine("Students grouped by groups using LINQ:");
            var studentsGroupedByGrNo = from student in students
                                        group student by student.GroupNumber
                                        into stGroups
                                        orderby stGroups.Key ascending
                                        select new
                                        {
                                            Group = stGroups.Key,
                                            student = stGroups.ToList()
                                        };

            foreach (var student in studentsGroupedByGrNo)
            {
                Console.WriteLine("Students from Group {0}:", student.Group);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(string.Join("\n", student.student));
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine();

            // task 19
            Console.WriteLine("Students grouped by groups using expressions:");
            var studentsGroupedByGrNo2 = students.GroupBy(x => x.GroupNumber)
                                        .OrderBy(x => x.Key);
            
            foreach (var student in studentsGroupedByGrNo2)
            {
                Console.WriteLine("Students from Group {0}:", student.Key);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(string.Join("\n", student));
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine();
        }

        private static void Print<T>(IEnumerable<T> students)
        {
            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(student);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
