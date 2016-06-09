using System;
using System.Collections.Generic;


namespace Events
{
    public class Subscriber
    {
        private string id;

        public Subscriber(string id, Publisher publisher)
        {
            this.id = id;
            publisher.RaiseCustomEvent += HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, CustomEventInfo e)
        {
            Console.WriteLine(id + " has read this massage {0}", e.Massage);
        }
    }
}
