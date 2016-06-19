namespace _02.BankAccounts.AccountClasses
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(int customerID, string name, decimal balnce, double interest, Customers customer)
            : base(customerID, name, balnce, interest, customer)
        {
        }

        public void Deposit(decimal amountDeposit)
        {
            this.Balance += amountDeposit;
        }

        public override decimal InterestAmount(int months)
        {
            if ((this.Customer == Customers.Individual && months <= 3) ||
                (this.Customer == Customers.Company && months <= 2))
            {
                return 0;
            }
            else if (this.Customer == Customers.Individual)
            {
                return base.InterestAmount(months - 3);
            }
            else
            {
                return base.InterestAmount(months - 2);
            }
        }
    }
}