namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsinCourse = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public void AddStudentInCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Cannot add null student in course!");
            }

            if (this.Students.Count > MaxStudentsinCourse)
            {
                throw new ArgumentOutOfRangeException(string.Format("Students in course cannot be greather than {0}", MaxStudentsinCourse));
            }

            this.Students.Add(student);
        }

        public void RemoveStudentFromCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Cannot remove null student in course!");
            }

            this.Students.Remove(student);
        }
    }
}
