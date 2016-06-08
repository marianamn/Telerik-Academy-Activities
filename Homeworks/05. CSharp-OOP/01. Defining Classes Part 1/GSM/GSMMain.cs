namespace GSM_Main
{
    using System;
    using GSM;

    public class GSMMain
    {
        public static void Main()
        {
            // problem 7
            int someNumber = 1;
            GSMTest.DisplayInfo(GSMTest.GenetareGSMs(someNumber));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();

            // problem 12
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}
