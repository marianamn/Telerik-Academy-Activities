using System;

namespace _02.ExceptionHandling.Exams
{
    public class SimpleMathExam : Exam
    {
        private const int MaxProblemSolved = 10;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Problem solved for this exam cannot be negative numbers!");
                }

                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Problem solved for this exam cannot be more than {0}!",  MaxProblemSolved));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: half of the job done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Excelent result: everything done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}