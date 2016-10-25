namespace DecoratorPattern
{
    using System;

    public class PhotographyService : EventServiceDecorator
    {
        public PhotographyService(IEventService eventService)
            : base(eventService)
        {
        }

        public override decimal Cost
        {
            get
            {
                // Cost of whatever event service represented by EventService + Photography service
                return base.Cost + 15000;
            }
        }
    }
}
