namespace DecoratorPattern
{
    using System;

    public class SeminarService : EventService
    {
        public override decimal Cost
        {
            get
            {
                // Service charge for overall management
                return 5000;   
            }
        }
    }
}
