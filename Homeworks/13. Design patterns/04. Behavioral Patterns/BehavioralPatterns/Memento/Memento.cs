namespace Memento
{
    using System;

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        private string name;
        private string phone;
        private double budget;

        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this.name = name;
            this.phone = phone;
            this.budget = budget;
        }

        // Gets or sets name
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Gets or set phone
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return this.budget; }
            set { this.budget = value; }
        }
    }
}
