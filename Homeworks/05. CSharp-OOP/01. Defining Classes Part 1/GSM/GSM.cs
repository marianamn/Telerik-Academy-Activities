namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        // problem 1
        private static GSM iphone4S;            // add in problem 6
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;        // add in problem 9

        // problem 6
        static GSM()
        {
            Iphone4S = new GSM(
                               "Iphone4S", 
                               "Apple", 
                               1500m, 
                               "Maria", 
                               new Battery("Gold", 400, 20, BatteryType.NiCd),
                               new Display(9, 1000670), 
                               new List<Call>());
        }

        // problem 2 - model and manufacturer are mandatory (the others are optional)
        public GSM(string model, string manufacturer) : this(model, manufacturer, 500m, "Ivan", new Battery(), new Display(), new List<Call>())
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = callHistory;   // add in problem 9
        }

        // add in problem 6
        public static GSM Iphone4S
        {
            get
            {
                return iphone4S;
            }

            private set
            {
                iphone4S = value;
            }
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty!");
                }
                else if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentException("Manufacturer name should be longer than 0 and shorter than 20 letters");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value == 0 || value > 2000)
                {
                    throw new ArgumentOutOfRangeException("Price should be > 0 and <= 2000");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            private set
            {
                if (value.Length == 0 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be longer than 0 and shorter than 30 letters");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            private set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        // problem 4
        public override string ToString()
        {
            return string.Format(
                                "Model: {0}" + "\nManufacturer: {1}" + "\nPrice: {2}" + "\nOwner: {3}" + "\nBattery: \n{4}" + "\nDisplay: \n{5}",
                                this.Model, 
                                this.Manufacturer, 
                                this.Price, 
                                this.Owner,
                                this.Battery.ToString(), 
                                this.Display.ToString());
        }

        // problem 10
        public List<Call> AddCall(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }

        // problem 11
        public decimal CallPrice(decimal pricePerMin)
        {
            decimal totalDuration = 0;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                totalDuration += this.CallHistory[i].Duration;
            }

            decimal totalPrice = pricePerMin * totalDuration / 60;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls History: \n{0}", string.Join("\n", this.callHistory));
        }
    }
}
