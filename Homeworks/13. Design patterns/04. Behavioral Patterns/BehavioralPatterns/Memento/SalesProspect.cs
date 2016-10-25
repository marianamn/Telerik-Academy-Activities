namespace Memento
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProspect
    {
        private string name;
        private string phone;
        private double budget;

        // Gets or sets name
        public string Name
        {
            get 
            {
                return this.name; 
            }

            set
            {
                this.name = value;
                Console.WriteLine("Name:  " + this.name);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get 
            {
                return this.phone; 
            }

            set
            {
                this.phone = value;
                Console.WriteLine("Phone: " + this.phone);
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get 
            {
                return this.budget; 
            }

            set
            {
                this.budget = value;
                Console.WriteLine("Budget: " + this.budget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(this.name, this.phone, this.budget);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}
