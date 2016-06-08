namespace GSM
{
    using System;

    public class Battery
    {
        // problem 1
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;     // add in problem 3

        // problem 2
        public Battery()
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        // problem 5
        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("Model is too short! It should be at least 2 letters");
                }

                if (value.Length >= 15)
                {
                    throw new ArgumentException("Model is too long! It should be less than 15 letters");
                }

                this.model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            private set
            {
                if (value == 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be > 0 and <= 500");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                if (value == 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be > 0 and <= 50");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            private set
            {
                this.batteryType = value;
            }
        }

        // problem 4
        public override string ToString()
        {
            return string.Format(
                                "Model: {0} \nHours idle: {1} \nHours talk: {2} \nType: {3}",
                                this.Model, 
                                this.HoursIdle, 
                                this.HoursTalk, 
                                this.BatteryType);
        }
    }
}
