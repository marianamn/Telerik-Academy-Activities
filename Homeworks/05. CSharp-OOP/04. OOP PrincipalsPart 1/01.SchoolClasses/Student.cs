namespace _01.SchoolClasses
{
    using System;

    public class Student : People, IComments
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be less or equal to zero!");
                }

                this.classNumber = value;
            }
        }

        public string Comments { get; private set; }

        public string MakeComments()
        {
            return this.Comments;
        }
    }
}
