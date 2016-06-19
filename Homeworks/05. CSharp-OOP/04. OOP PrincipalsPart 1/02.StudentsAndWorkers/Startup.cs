namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<Student> students = new List<Student> { new Student ("Ivan","Dimitrov", 4),
                                                         new Student ("Maria","Petrova", 5),
                                                         new Student ("Pesho","Goshev", 6),
                                                         new Student ("Deyan","Veselinov", 3),
                                                         new Student ("Iva","Dinev", 4),
                                                         new Student ("Ani","Boyanova", 5),
                                                         new Student ("Georgy","Peshev", 2),
                                                         new Student ("Savin","Lilov", 2),
                                                         new Student ("Stela","Yaneva", 3),
                                                         new Student ("Yordan","Gogov", 6),};

            Console.WriteLine("Initial list with students:");
            PrintCollection(students);

            Console.WriteLine("Sorted students by Grade - ascending order:");
            var studentsByGrade = students.OrderBy(x => x.Grade);
            PrintCollection(studentsByGrade);

            List<Worker> workers = new List<Worker> { new Worker ("Ivan","Dimitrov", 300, 20),
                                                      new Worker ("Maria","Petrova", 400, 22),
                                                      new Worker ("Pesho","Goshev", 250, 10),
                                                      new Worker ("Deyan","Veselinov",350, 50),
                                                      new Worker ("Iva","Dinev",320, 20),
                                                      new Worker ("Ani","Boyanova",350, 40),
                                                      new Worker ("Georgy","Peshev",280, 30),
                                                      new Worker ("Savin","Lilov", 160, 45),
                                                      new Worker ("Stela","Yaneva", 146, 30),
                                                      new Worker ("Yordan","Gogov", 180,10),};

            Console.WriteLine("Initial list with workers:");
            PrintCollection(workers);

            Console.WriteLine("Sorted workers by received money per hour - descending order:");
            var workersByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
            PrintCollection(workersByMoneyPerHour);

            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            var sortedMergedList = mergedList.OrderBy(x => x.FirstName)
                                             .ThenBy(x => x.LastName);
            Console.WriteLine("Sorted merged list from workers and students - by first and last name:");

            foreach (var item in sortedMergedList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
