namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cnnot be null, empty or white space!");
                }

                this.name = value;
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
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range [1,50]");
                }

                this.age = value;
            }
        }

        public Gender Gender { get; private set; }

        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}, gender: {2}", this.name.ToString(), this.age, this.Gender);
        }

        public abstract void MakeSound();
    }
}