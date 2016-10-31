using System.Collections.Generic;
using System.Data.Entity.Migrations;
using StudentSystem.Models;

namespace StudentSystem.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            this.SeedCourses(context);
            this.SeedStudents(context);
        }

        private void SeedStudents(StudentSystemDbContext context)
        {
            context.Students
                .AddOrUpdate(
                s => s.Name,
                new Student
                {
                    Name = "Ilian Ivanov",
                    StudentNumber = 12345
                },
                new Student
                {
                    Name = "Mimi Hristova",
                    StudentNumber = 12345
                });
        }

        private void SeedCourses(StudentSystemDbContext context)
        {
            context.Courses
                .AddOrUpdate(
                c => c.Name,
                new Course
                {
                    Name = "Database",
                    Description = "MSSQL",
                    Students = new List<Student>()
                },
                new Course
                {
                    Name = "JavaScript",
                    Description = "Single Apps",
                    Students = new List<Student> { new Student { Name = "Hristo Petrov" } }
                });
        }
    }
}
