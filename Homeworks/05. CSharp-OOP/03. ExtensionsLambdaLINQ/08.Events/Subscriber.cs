namespace _08.Events
{
    using System;

    public class Subscriber
    {
        private string id;

        public Subscriber(string id, Publisher publisher)
        {
            this.id = id;
            publisher.RaiseCustomEvent += this.HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, CustomEventInfo e)
        {
            Console.WriteLine(this.id + " has read this massage {0}", e.Massage);
        }
    }
}
