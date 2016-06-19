namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School : IComments
    {
        private string identifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public School(string identifier, List<Teacher> teachers, List<Student> students)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.identifier = value;
            }
        }

        public List<Teacher> Teachers { get; private set; }

        public List<Student> Students { get; private set; }

        public string Comments { get; private set; }

        public string MakeComments()
        {
            return this.Comments;
        }
    }
}
