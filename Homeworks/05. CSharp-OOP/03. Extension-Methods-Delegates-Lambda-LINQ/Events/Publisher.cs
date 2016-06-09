using System;
using System.Collections.Generic;

namespace Events
{
    public class Publisher
    {
        public event EventHandler<CustomEventInfo> RaiseCustomEvent;

        public void MassageToCustomers()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Dear customers for better contact, please sent us an e-mail.");
            Console.WriteLine("------------------------------------------------------------");
            OnRaisedCustomEvent(new CustomEventInfo("-"));
        }

        protected virtual void OnRaisedCustomEvent(CustomEventInfo e)
        {
            EventHandler<CustomEventInfo> handler = RaiseCustomEvent;
            if (handler != null)
            {
                e.Massage += String.Format(" at {0}.", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }
}
