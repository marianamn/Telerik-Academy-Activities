namespace _02.BankAccounts.AccountClasses
{
    using System;

    public abstract class Account
    {
        private int customerID;
        private string name;
        private decimal balance;
        private double interest;
        private Customers customer;

        public Account(int customerID, string name, decimal balance, double interest, Customers customer)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Balance = balance;
            this.Interest = interest;
            this.Customer = customer;
        }

        public int CustomerID
        {
            get
            {
                return this.customerID;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Customer ID number must be positive number!");
                }

                this.customerID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null");
                }

                this.name = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interest rate must be positive number!");
                }

                this.interest = value;
            }
        }

        public Customers Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public virtual decimal InterestAmount(int months)
        {
            decimal interestAmount = months * this.Balance * (decimal)(this.Interest / 100);
            return interestAmount;
        }

        public override string ToString()
        {
            return string.Format(
                                "name: {0} balance: {1} int. rate: {2:F2}%   {3}",
                                this.name.ToString().PadRight(11), 
                                this.balance.ToString().PadRight(6),
                                this.interest, 
                                this.Customer);
        }
    }
}