namespace Observer
{
    using System;

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;

        // Constructor
        public Investor(string name)
        {
            this.name = name;
        }

        // Gets or sets the stock
        public Stock Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", this.name, this.stock.Symbol, this.stock.Price);
        }
    }
}
