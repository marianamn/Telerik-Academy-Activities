/*Problem 9. Student groups
• Create a class  Student  with properties  FirstName ,  LastName ,  FN ,  Tel ,  Email ,  
  Marks  (a List),  GroupNumber .
• Create a  List<Student>  with sample students. Select only the students that are from group number 2.
• Use LINQ query. Order the students by FirstName.
 
Problem 10. Student groups extensions
• Implement the previous using the same query expressed with extension methods.

Problem 11. Extract students by email
• Extract all students that have email in  abv.bg .
• Use  string  methods and LINQ.

Problem 12. Extract students by phone
• Extract all students with phones in Sofia.
• Use LINQ. 

Problem 13. Extract students by marks
• Select all students that have at least one mark  Excellent  ( 6 ) into a new anonymous class 
  that has properties –  FullName  and  Marks .
• Use LINQ.

Problem 15. Extract marks
• Extract all  Marks  of the students that enrolled in 2006. 
  (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

Problem 16.* Groups
• Create a class  Group  with properties  GroupNumber  and  DepartmentName .
• Introduce a property  GroupNumber  in the  Student  class.
• Extract all students from "Mathematics" department.
• Use the  Join  operator.

Problem 17. Longest string
• Write a program to return the string with maximum length from an array of strings.
• Use LINQ.

Problem 18. Grouped by GroupNumber
• Create a program that extracts all students grouped by  GroupNumber  and then prints them to the console.
• Use LINQ

Problem 19. Grouped by GroupName extensions
• Rewrite the previous using extension methods.

 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractStudentsInfo
{
    public class ExtractStudentsInfoMain
    {
        public static void Main()
        {
            Student[] students = {new Student ("Georgi", "Stoianov", 123406, "+35928249226", "georgi@abv.bg",
                                                new List<double> { 2, 4.50, 3, 6 }, 3),
                                  new Student ("Pesho", "Goshev", 456789, "+35988565635", "pesho@gmail.com",
                                                new List<double> { 5, 2, 2, 5.50 }, 2),
                                  new Student ("Nikolai", "Kolev", 123789, "088565675", "nikolai@abv.bg",
                                                new List<double> { 3, 4, 6, 6, 2}, 1),
                                  new Student ("Ani", "Vasileva", 343406, "088845635", "ani@mail.bg",
                                                new List<double> { 4, 5.45, 3.20, 4 }, 2),
                                  new Student ("Maria", "Pavlova", 156789, "028562375", "maria@abv.bg",
                                                new List<double> { 2, 4.30, 6, 5}, 1),
                                 };

            Console.WriteLine("Students Initial List");
            Print(students);


            //problem 9
            var studentsGroup2 = (from student in students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName ascending
                                  select student);
            Console.WriteLine("Students from Group 2, sorted by First Name (LINQ)");
            Print(studentsGroup2);


            //problem 10
            var studentsGroup2ext = students.Where(x => x.GroupNumber == 2)
                                            .OrderBy(x => x.FirstName);
            Console.WriteLine("Students from Group 2, sorted by First Name (Extention method)");
            Print(studentsGroup2ext);


            //problem 11
            var studentsAbvMail = (from student in students
                                   where student.Email.Contains("abv.bg")
                                   select student);
            Console.WriteLine("Students with abv.bg e-mail (LINQ)");
            Print(studentsAbvMail);


            //problem 12
            var studentsPhonesInSofia = (from student in students
                                         where student.PhoneNumber.StartsWith("02") || student.PhoneNumber.StartsWith("+3592")
                                         select student);
            Console.WriteLine("Students with phone in Sofia (LINQ)");
            Print(studentsPhonesInSofia);


            //problem 13
            var studentsWithExcelentMarks = (from student in students
                                             where student.Marks.Contains(6)
                                             select new
                                             {
                                                 fullName = student.FirstName + " " + student.LastName,
                                                 marks = student.Marks
                                             });

            Console.WriteLine("Students with at least one excelent mark 6 (LINQ)");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Full Name            Marks");
            Console.WriteLine("------------------------------------------------------------------------------");

            foreach (var student in studentsWithExcelentMarks)
            {
                Console.Write("{0, -20} ", student.fullName);
                Console.Write("[{0}]", string.Join(", ", student.marks));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            //problem 14
            var studentsWithTwo2 = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2);
            Console.WriteLine("Students with exact 2 marks equal to 2 (Extention method)");
            Print(studentsWithTwo2);


            //problem 15
            var studentsRegIn2006 = (from student in students
                                     where student.FacNumber % 100 == 06
                                     select new { marks = student.Marks });

            Console.WriteLine("Students registered in 2006 marks (LINQ)");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Marks");
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var student in studentsRegIn2006)
            {
                Console.Write("[{0}]", string.Join(", ", student.marks));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            //problem 16
            string[] departments = new[] { "Literature", "Mathematics", "IT" };
            Group[] groups = new[] {new Group(1, departments[0]),
                                    new Group(2, departments[1]),
                                    new Group(3, departments[2])};

            var studentsFromMathDept = (from certianGroup in groups
                                        where certianGroup.GroupNumber == 2
                                        join student in students on certianGroup.GroupNumber equals student.GroupNumber
                                        select new
                                        {
                                            fullName = student.FirstName + " " + student.LastName,
                                            depatrment = certianGroup.DepartmentName
                                        });

            Console.WriteLine("Students from Math Department (LINQ)");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Full Name            Department");
            Console.WriteLine("------------------------------------------------------------------------------");

            foreach (var student in studentsFromMathDept)
            {
                Console.Write("{0, -20} ", student.fullName);
                Console.Write("{0}", student.depatrment);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            //problem 17
            var largestString = (from dept in departments
                                 select dept).Max();

            Console.WriteLine("Departments array [{0}]", string.Join(", ", departments));
            Console.WriteLine("It's largest string is: {0}", largestString);
            Console.WriteLine();
            Console.WriteLine();


            //problem 18
            var studentsGroupedByGrNo = (from student in students
                                         group student by student.GroupNumber 
                                         into stGroups
                                         orderby stGroups.Key ascending
                                         select new
                                         {
                                             Group = stGroups.Key,
                                             student = stGroups.ToList()
                                         });

            Console.WriteLine("------------------------------Using LINQ---------------------------------");
            foreach (var student in studentsGroupedByGrNo)
            {
                Console.WriteLine("Students from Group {0}:\n{1}", student.Group, 
                                  string.Join("\n", student.student));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            //problem 19
            var studentsGroupedByGrNo2 = students.GroupBy(x => x.GroupNumber)
                                         .OrderBy(x => x.Key);

            Console.WriteLine("--------------------------Using expressions-------------------------------");
            foreach (var student in studentsGroupedByGrNo2)
            {
                Console.WriteLine("Students from Group {0}:\n{1}", student.Key,
                                  string.Join("\n", student));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
      



        public static void Print<T>(IEnumerable<T> students)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Fst Name Scnd Name FN      GSM           e-mail         Gr.No   Marks");
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
