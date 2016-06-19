namespace _01.SchoolClasses
{
    using System;

    public class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
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
                    throw new ArgumentNullException("Name cannot be empty or null!");
                }

                this.name = value;
            }
        }
    }
}