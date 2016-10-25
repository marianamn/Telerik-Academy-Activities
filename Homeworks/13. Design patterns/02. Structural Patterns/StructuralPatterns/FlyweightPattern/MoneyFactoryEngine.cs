namespace FlyweightPattern
{
    using System;
    using System.Collections.Generic;

    public class MoneyFactoryEngine
    {
        public static void Main(string[] args)
        {
            const int TEN_TOUSENT = 10000;
            
            int[] currencyDenominations = new[] { 1, 5, 10, 20, 50, 100 };
            MoneyFactory moneyFactory = new MoneyFactory();
            
            int sum = 0;
            
            while (sum <= TEN_TOUSENT)
            {
                IMoney graphicalMoneyObj = null;
                Random rand = new Random();
                
                int currencyDisplayValue = currencyDenominations[rand.Next(0, currencyDenominations.Length)];

                if (currencyDisplayValue == 1 || currencyDisplayValue == 5)
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(MoneyType.Metallic);
                }
                else
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(MoneyType.Paper);
                }

                graphicalMoneyObj.GetDisplayOfMoneyFalling(currencyDisplayValue);
                sum = sum + currencyDisplayValue;
            }
            
            Console.WriteLine("Total Objects created=" + MoneyFactory.objectsCount.ToString());
            Console.ReadLine();
        }
    }
}
