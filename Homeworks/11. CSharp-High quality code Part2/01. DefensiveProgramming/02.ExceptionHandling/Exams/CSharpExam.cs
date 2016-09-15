using System;

namespace _02.ExceptionHandling.Exams
{
    public class CSharpExam : Exam
    {
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score 
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("Score cannot be null!");
                }

                if (this.score < 0 || this.score > 100)
                {
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 100!");
                }

                this.score = value;
            } 
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
