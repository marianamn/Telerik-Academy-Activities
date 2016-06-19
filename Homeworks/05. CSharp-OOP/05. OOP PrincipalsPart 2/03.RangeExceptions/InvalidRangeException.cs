namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public T Start
        {
            get { return this.start; }
        }

        public T End
        {
            get { return this.end; }
        }

        public override string Message
        {
            get
            {
                return string.Format("is not in the range [{0},{1}]", this.start, this.end);
            }
        }
    }
}
