namespace _07.Timer
{
    using System;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            //at each 5 seconds on the Console will be written text "tick" 
            //and this action will be repeated 3 times
            Timer timer = new Timer(5, 3, delegate () { Console.WriteLine("tick"); });
            Thread timerThread = new Thread(new ThreadStart(timer.Run));
            timerThread.Start();
        }
    }
}
