namespace _01.School
{
    using System;

    public class Student
    {
        private const int IdMin = 10000;
        private const int IdMax = 99999;

        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < IdMin || value > IdMax)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Id must be between {0} and {1}", IdMin, IdMax));
                }

                this.id = value;
            }
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
                    throw new ArgumentNullException("Student name cannot be null or empty");
                }

                this.name = value;
            }
        }
    }
}
