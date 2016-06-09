using System;

namespace Events
{
    public class CustomEventInfo : EventArgs
    {
        private string massage;

        public CustomEventInfo(string massage)
        {
            this.Massage = massage;
        }

        public string Massage
        {
            get { return this.massage; }
            set { this.massage = value; }
        }
    }
}
