using System;
using System.Collections.Generic;
using System.Linq;
using _02.ExceptionHandling.Exams;

namespace _02.ExceptionHandling
{
    public class Student
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 20;
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }

                if (value.Length < MinNameLength || value.Length > MaxNameLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format("First name must be between {0} and {1} symbols!", MinNameLength, MaxNameLength));
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

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }

                if (value.Length < MinNameLength || value.Length > MaxNameLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Last name must be between {0} and {1} symbols!", MinNameLength, MaxNameLength));
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams { get; private set; }

        internal IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();

            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        internal double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException("Cannot calculate average on missing exams!");
            }

            if (this.Exams.Count == 0)
            {
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];

            IList<ExamResult> examResults = this.CheckExams();

            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade) /
                               (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}