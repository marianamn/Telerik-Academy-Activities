namespace _07.Timer
{
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        private int timeInterval;
        private byte ticks;
        private TimerDelegate timeEvent;

        public Timer(int timeInterval, byte ticks, TimerDelegate timeEvent)
        {
            this.TimeInterval = timeInterval;
            this.Ticks = ticks;
            this.TimeEvent = timeEvent;
        }

        public int TimeInterval
        {
            get { return this.timeInterval; }
            set { this.timeInterval = value; }
        }

        public byte Ticks
        {
            get { return this.ticks; }
            set { this.ticks = value; }
        }

        public TimerDelegate TimeEvent
        {
            get { return this.timeEvent; }
            set { this.timeEvent = value; }
        }

        public void Run()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.timeInterval * 1000);
                this.ticks--;
                this.TimeEvent();
            }
        }
    }
}
