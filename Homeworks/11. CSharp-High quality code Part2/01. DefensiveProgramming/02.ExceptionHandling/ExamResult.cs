using System;

namespace _02.ExceptionHandling
{
    public class ExamResult
    {
        private const int MinCommentsLength = 3;
        private const int MaxCommentsLength = 250;
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grades cannot be negative numbers!");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MinGrades cannot be negative number!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.minGrade)
                {
                    throw new ArithmeticException("MaxGrades cannot be bigger than MinGrades");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Comments cannot be empty string!");
                }

                if (value.Length < MinCommentsLength || value.Length > MaxCommentsLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Comments must be between {0} and {1} symbols!", MinCommentsLength, MaxCommentsLength));
                }

                this.comments = value;
            }
        }
    }
}