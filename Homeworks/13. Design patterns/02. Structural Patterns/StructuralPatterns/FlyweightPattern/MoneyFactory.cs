namespace FlyweightPattern
{
    using System;
    using System.Collections.Generic;

    public class MoneyFactory
    {
        public static int objectsCount = 0;
        private Dictionary<MoneyType, IMoney> moneyObjects;

        public IMoney GetMoneyToDisplay(MoneyType form)
        {
            if (this.moneyObjects == null)
            {
                this.moneyObjects = new Dictionary<MoneyType, IMoney>();
            }
            else if (this.moneyObjects.ContainsKey(form))
            {
                return this.moneyObjects[form];
            }

            switch (form)
            {
                case MoneyType.Metallic:
                    this.moneyObjects.Add(form, new MetallicMoney());
                    objectsCount++;
                    break;
                case MoneyType.Paper:
                    this.moneyObjects.Add(form, new PaperMoney());
                    objectsCount++;
                    break;
                default:
                    break;
            }

            return this.moneyObjects[form];
        }
    }
}