namespace _02.BankAccounts.AccountClasses
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(int customerID, string name, decimal balnce, double interest, Customers customer)
            : base(customerID, name, balnce, interest, customer)
        {
        }

        public void Deposit(decimal amountDeposit)
        {
            this.Balance += amountDeposit;
        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0;

            if (this.Customer == Customers.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    interestAmount = base.InterestAmount(months - 6);
                }
            }

            if (this.Customer == Customers.Company)
            {
                if (months > 12)
                {
                    decimal interestAmountFirst12Month = 12 * this.Balance * (decimal)(this.Interest / 100 / 2);
                    decimal interestAfrer12thMonth = base.InterestAmount(months - 12);
                    interestAmount = interestAmountFirst12Month + interestAfrer12thMonth;
                }
                else
                {
                    interestAmount = months * this.Balance * (decimal)(this.Interest / 100 / 2);
                }
            }

            return interestAmount;
        }
    }
}
