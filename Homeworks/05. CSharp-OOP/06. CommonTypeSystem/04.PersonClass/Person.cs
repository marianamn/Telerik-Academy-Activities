namespace _04.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative number and greeter than 150!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return string.Format("Name: {0}, age: not specified", this.name);
            }
            else
            {
                return string.Format("Name: {0}, age: {1}", this.name, this.age);
            }
        }
    }
}