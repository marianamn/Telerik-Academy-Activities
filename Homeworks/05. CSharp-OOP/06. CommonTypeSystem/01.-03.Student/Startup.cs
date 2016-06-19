namespace _01._03.Student
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(
                "Pesho", 
                "Stoyanov", 
                "Peev", 
                123, 
                "Sofia - ul. Tree 4",
                "+35928249226", 
                "georgi@abv.bg",
                2, 
                Universities.UNWE, 
                Faculties.Economy, 
                Specialties.Accounting);

            Student student2 = new Student(
                "Pesho", 
                "Goshev", 
                "Goshov", 
                100, 
                "Sofia - ul. Vitosha 56",
                "+35988565635",
                "pesho@gmail.com",
                3, 
                Universities.SU, 
                Faculties.IT,
                Specialties.Java);

            // problem 1
            FormatingColored();
            Console.WriteLine("Initial information for Students:");
            FormatingGray();

            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine();

            FormatingColored();
            Console.WriteLine("Overrided GetHashCode() for Student 1:");
            FormatingGray();
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine();

            FormatingColored();
            Console.WriteLine("Overrided Equals(), checking first name of both students:");
            FormatingGray();
            Console.WriteLine(student1.FirstName.Equals(student2.FirstName));
            Console.WriteLine();

            FormatingColored();
            Console.WriteLine("Overrided operator ==, checking if student 1 == student 2:");
            FormatingGray();
            Console.WriteLine(student1 == student2);
            Console.WriteLine();

            FormatingColored();
            Console.WriteLine("Overrided operator !=, checking if student 1 != student 2:");
            FormatingGray();
            Console.WriteLine(student1 != student2);
            Console.WriteLine();
            
            // problem 2
            FormatingColored();
            Console.WriteLine("Deep copy of student 1:");
            FormatingGray();
            Student deepCopyStudent1 = student1.Clone() as Student;
            Console.WriteLine(deepCopyStudent1);
            Console.WriteLine();

            FormatingColored();
            Console.WriteLine("Change the deep copy of student 1 and print: \ndeep copy - changed \nstudent 1 - remain the same");
            FormatingGray();

            deepCopyStudent1.FirstName = "Ivan";
            deepCopyStudent1.MiddleName = "Ivanov";
            deepCopyStudent1.LastName = "Ivanov";
            deepCopyStudent1.SocialNumber = 345;
            deepCopyStudent1.Address = "Pleven - ul. Grad 4";
            deepCopyStudent1.Phone = "0888768956";
            Console.WriteLine(deepCopyStudent1);
            Console.WriteLine();
            Console.WriteLine(student1);
            Console.WriteLine();
            
            // problem 3
            FormatingColored();
            Console.WriteLine("Implement method CompareTo() for student 1 and student 2");
            FormatingGray();
            Console.WriteLine(student1.CompareTo(student2));
            Console.WriteLine();
        }

        public static void FormatingColored()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void FormatingGray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}