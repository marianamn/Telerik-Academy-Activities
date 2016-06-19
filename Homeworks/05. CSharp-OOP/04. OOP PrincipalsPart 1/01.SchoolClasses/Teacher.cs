namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, IComments
    {
        private List<Disciplines> disciplines;

        public Teacher(string name, List<Disciplines> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            private set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException("One teacher could teach at least one discipline!");
                }

                this.disciplines = value;
            }
        }

        public string Comments { get; private set; }

        public string MakeComments()
        {
            return this.Comments;
        }
    }
}