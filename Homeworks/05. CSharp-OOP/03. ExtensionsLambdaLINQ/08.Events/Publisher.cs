namespace _08.Events
{
    using System;

    public class Publisher
    {
        public event EventHandler<CustomEventInfo> RaiseCustomEvent;

        public void MassageToCustomers()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Dear customers for better contact, please sent us an e-mail.");
            Console.WriteLine("------------------------------------------------------------");
            this.OnRaisedCustomEvent(new CustomEventInfo("-"));
        }

        protected virtual void OnRaisedCustomEvent(CustomEventInfo e)
        {
            EventHandler<CustomEventInfo> handler = this.RaiseCustomEvent;
            if (handler != null)
            {
                e.Massage += string.Format(" at {0}.", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }
}
