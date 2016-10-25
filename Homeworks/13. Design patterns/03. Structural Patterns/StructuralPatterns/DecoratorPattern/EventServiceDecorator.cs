namespace DecoratorPattern
{
    using System;

    public abstract class EventServiceDecorator : EventService
    {
        private IEventService eventServiceObj;

        public EventServiceDecorator(IEventService eventService)
        {
            this.eventServiceObj = eventService;
        }

        public override decimal Cost
        {
            get
            {
                return this.eventServiceObj.Cost;
            }
        }
    }
}
