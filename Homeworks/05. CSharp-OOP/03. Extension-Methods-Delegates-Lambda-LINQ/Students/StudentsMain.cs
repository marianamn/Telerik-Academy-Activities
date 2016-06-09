/*Problem 3. First before last
• Write a method that from a given array of students finds all students whose first name is before 
  its last name alphabetically.
• Use LINQ query operators.

Problem 4. Age range
• Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

Problem 5. Order students
• Using the extension methods  OrderBy()  and  ThenBy()  with lambda expressions sort the students 
  by first name and last name in descending order.
• Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    public class StudentsMain
    {
        public static void Main()
        {
            Student[] students = { new Student ("Anton", "Ivanov", 17),
                                   new Student ("Petar", "Filipov", 20),
                                   new Student ("Maria", "Nikolova", 25),
                                   new Student ("Pavel", "Simeonov", 19),
                                   new Student ("Pavel", "Dimitrov", 23),
                                   new Student ("Nadia", "Trifonova", 22)};
            
            Console.WriteLine("Students:");
            PrintStudens(students);
            Console.WriteLine();

            //problem 3
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            var result = students.Where(x => x.FirstName.CompareTo(x.LastName) == -1);
            PrintStudens(result);
            Console.WriteLine();

            //problem 4
            Console.WriteLine("Students between 18 and 24:");
            var result1 = students.Where(x => x.Age >= 18 && x.Age <= 24);
            PrintStudens(result1);
            Console.WriteLine();

            //problem 5 - using lambda extension methods
            Console.WriteLine("Students sorted in descending order using lambda extension methods:");
            var result2 = students.OrderByDescending(x => x.FirstName)
                                  .ThenByDescending(x => x.LastName);
            PrintStudens(result2);
            Console.WriteLine();
            

            //problem 5 - using LINQ query keywords
            Console.WriteLine("Students sorted in descending order using LINQ query keywords:");
            var result3 = 
                          (from student in students
                           orderby student.FirstName descending,
                           student.LastName descending
                           select student);
            PrintStudens(result3);
        }

        
        public static void PrintStudens<T>(IEnumerable<T> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}
