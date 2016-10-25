namespace FlyweightPattern
{
    using System;

    public class PaperMoney : IMoney
    {
        public MoneyType MoneyType
        {
            get { return MoneyType.Paper; }
        }

        // GetExtrinsicState()
        public void GetDisplayOfMoneyFalling(int moneyValue) 
        {
            // This method would display a graphical representation of a paper currency.
            Console.WriteLine(string.Format("Displaying a graphical object of {0} currencyof value ${1} falling from sky.", MoneyType.ToString(), moneyValue));
        }
    }
}
