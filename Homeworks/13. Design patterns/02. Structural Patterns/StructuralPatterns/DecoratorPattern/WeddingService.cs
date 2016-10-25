namespace DecoratorPattern
{
    using System;

    public class WeddingService : EventService
    {
        public override decimal Cost
        {
            get
            {
                // Service charge for overall management
                return 10000;   
            }
        }
    }
}
