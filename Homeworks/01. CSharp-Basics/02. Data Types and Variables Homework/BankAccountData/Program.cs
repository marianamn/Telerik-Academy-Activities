/*Problem 11. Bank Account Data
• A bank account has a holder name (first name, middle name and last name), 
 available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
• Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        string holderName = "Ivan Petrov Ivanov";
        decimal amountofMoney = 3450.68m;
        string bankName = "United Bulgarian Bank";
        string iban = "BG80UBB800000000000000";
        long creditCard1 = 123456789012345;
        long creditCard2 = 123456789012346;
        long creditCard3 = 123456789012347;

        Console.WriteLine("Account details:");
        Console.WriteLine("Holder name : {0}", holderName);
        Console.WriteLine("Amount : {0}", amountofMoney);
        Console.WriteLine("Bank name : {0}", bankName);
        Console.WriteLine("IBAN : {0}", iban);
        Console.WriteLine("First credit card number: {0}", creditCard1);
        Console.WriteLine("Second credit card number: {0}", creditCard2);
        Console.WriteLine("Third credit card number: {0}", creditCard3);
    }
}