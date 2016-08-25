namespace _01.EventsTask
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; private set; }

        public string Title { get; private set; }

        public string Location { get; private set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int orderByDate = this.date.CompareTo(other.Date);
            int orderByTitle = this.title.CompareTo(other.Title);
            int orderByLocation = this.location.CompareTo(other.Location);

            if (orderByDate == 0)
            {
                if (orderByTitle == 0)
                {
                    return orderByLocation;
                }
                else
                {
                    return orderByTitle;
                }
            }
            else
            {
                return orderByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            var dateFormat = "yyyy-MM-ddTHH:mm:ss";
            toString.Append(this.Date.ToString(dateFormat));
            toString.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}