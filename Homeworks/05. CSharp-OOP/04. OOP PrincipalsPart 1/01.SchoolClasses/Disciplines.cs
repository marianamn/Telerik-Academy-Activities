namespace _01.SchoolClasses
{
    using System;

    public class Disciplines : IComments
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Disciplines(string disciplineName, int numberOfLectures, int numberOfExcercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null!");
                }

                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be less or equal to zero!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of ecercises cannot be less or equal to zero!");
                }

                this.numberOfExcercises = value;
            }
        }

        public string Comments { get; private set; }

        public string MakeComments()
        {
            return this.Comments;
        }
    }
}