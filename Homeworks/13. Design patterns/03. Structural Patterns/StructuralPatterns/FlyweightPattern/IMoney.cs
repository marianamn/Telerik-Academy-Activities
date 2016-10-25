namespace FlyweightPattern
{
    using System;

    public interface IMoney
    {
        // IntrinsicState()
        MoneyType MoneyType { get; }
        
        // GetExtrinsicSate()
        void GetDisplayOfMoneyFalling(int moneyValue); 
    }
}
