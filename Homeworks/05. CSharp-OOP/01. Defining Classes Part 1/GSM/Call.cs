namespace GSM
{
    using System;

    public class Call
    {
        // problem 8
        private DateTime date;
        private DateTime time;
        private string diledPhones;
        private int duration;
        
        public Call()
        {
        }
        
        public Call(DateTime date, DateTime time, string diledPhones, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.Dieledphones = diledPhones;
            this.Duration = duration;
        }
        
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }

            private set
            {
                this.time = value;
            }
        }

        public string Dieledphones
        {
            get
            {
                return this.diledPhones;
            }

            set
            {
                this.diledPhones = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }
        }
        
        public override string ToString()
        {
            return string.Format(
                                "\nDate: {0:G} \nTime: {1} \nDiled phone: {2} \nDuration: {3}",
                                 this.Date.ToString("dd.MM.yyyy"), 
                                 this.Time.ToString("hh:mm:ss"),
                                 this.Dieledphones, 
                                 this.Duration);
        }
    }
}
