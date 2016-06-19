namespace _02.BankAccounts.AccountClasses
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(int customerID, string name, decimal balnce, double interest, Customers customer)
            : base(customerID, name, balnce, interest, customer)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amountWithdraw)
        {
            do
            {
                this.Balance -= amountWithdraw;
            }
            while (amountWithdraw > this.Balance);
        }

        public override decimal InterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return base.InterestAmount(months);
            }
        }
    }
}
