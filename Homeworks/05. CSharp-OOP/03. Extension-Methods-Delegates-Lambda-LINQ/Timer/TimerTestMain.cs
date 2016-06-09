/*Problem 7. Timer
 • Using delegates write a class  Timer  that can execute certain method at each  t  seconds.*/

using System;
using System.Threading;

namespace Timer
{
    public class TimerTestMain
    {
        public static void Main()
        {
            //at each 5 seconds on the Console will be written text "tick" 
            //and this action will be repeated 3 times
            Timer timer = new Timer(5, 3, delegate() { Console.WriteLine("tick"); });
            Thread timerThread = new Thread(new ThreadStart(timer.Run));
            timerThread.Start();
        } 
    }
}
