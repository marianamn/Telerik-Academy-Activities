using System;

namespace Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (age < 0 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - age {2}", this.firstName.ToString(), this.lastName.ToString(), this.age);
        }
    }
}
