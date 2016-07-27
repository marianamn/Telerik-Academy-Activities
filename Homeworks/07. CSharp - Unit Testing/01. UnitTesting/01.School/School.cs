namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private ICollection<Student> students;
        private ICollection<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
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
                    throw new ArgumentNullException("School name cannot be null or empty");
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

            private set
            {
                this.students = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }

            private set
            {
                this.courses = value;
            }
        }

        public void AddStudentInSchool(Student student)
        {
            if (this.Students.Any(x => x.Id == student.Id))
            {
                throw new ArgumentException("Student with such Id already exists!");
            }

            this.Students.Add(student);
        }

        public void RemoveStudentInSchool(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddCourseToSchool(Course course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourseToSchool(Course course)
        {
            this.Courses.Remove(course);
        }
    }
}
