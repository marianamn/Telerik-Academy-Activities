namespace StudentSystem.ConsoleApp
{
    using System;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using System.Data.Entity;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var db = new StudentSystemDbContext();

            Console.WriteLine(db.Students.Count());
        }
    }
}
