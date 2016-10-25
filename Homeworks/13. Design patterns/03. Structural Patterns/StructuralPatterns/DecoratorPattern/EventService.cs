namespace DecoratorPattern
{
    using System;

    public abstract class EventService : IEventService
    {
        public abstract decimal Cost { get; }
    }
}
