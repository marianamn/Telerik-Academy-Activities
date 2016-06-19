namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using AccountClasses;

    public class Startup
    {
        public static void Main()
        {
            Account[] accounts = 
            {
                new DepositAccount(1, "Ani Gogova", 4000, 2.50, Customers.Individual),
                new DepositAccount(2, "Pesho Gogov", 100, 2.50, Customers.Individual),
                new DepositAccount(3, "ABC OOD", 5000, 4.50, Customers.Company),

                new LoanAccount(1, "Ani Gogova", 1000, 7.50, Customers.Individual),
                new LoanAccount(2, "Pesho Gogov", 2000, 5.20, Customers.Individual),
                new LoanAccount(3, "ABC OOD", 50000, 3.50, Customers.Company),

                new MortgageAccount(1, "Ani Gogova", 10000, 8.50, Customers.Individual),
                new MortgageAccount(2, "Pesho Gogov", 20000, 9.70, Customers.Individual),
                new MortgageAccount(3, "ABC OOD", 100000, 5.10, Customers.Company)
            };

            PrintCollection(accounts);

            DepositAccount deposit = new DepositAccount(2, "Pesho Gogov", 100, 2.50, Customers.Individual);
            Console.WriteLine("Deposit:", deposit.Name);
            Console.WriteLine(deposit);

            decimal addAmount = 50;
            deposit.Deposit(addAmount);
            Console.WriteLine("Add {0} to deposit balance:\n{1}", addAmount, deposit);

            decimal withdrawAmount = 30;
            deposit.Withdraw(withdrawAmount);
            Console.WriteLine("Withdraw {0 } from deposit balance\n{1}", withdrawAmount, deposit);
            Console.WriteLine();

            int months = 13;

            Console.WriteLine("Calculated interest income for {0} months:", months);
            foreach (var item in accounts)
            {
                Console.WriteLine("{0} {1} - {2:0}", item.GetType().Name.PadRight(15), item.Name, item.InterestAmount(months));
            }
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("{0} {1}", item.GetType().Name.PadRight(15), item);
            }

            Console.WriteLine();
        }
    }
}