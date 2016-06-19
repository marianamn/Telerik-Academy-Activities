namespace _03_05.Students
{
    using System;

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
            get
            {
                return this.firstName;
            }

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
            get
            {
                return this.lastName;
            }

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
            get
            {
                return this.age;
            }

            private set
            {
                if (this.age < 0 || this.age > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, age:{2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
