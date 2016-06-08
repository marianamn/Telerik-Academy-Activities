namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        private const decimal Price = 0.37m;

        public static void TestCallHistory()
        {
            GSM testGSM = new GSM(
                                   "Smsung",
                                   "Galaxy",
                                   1000m,
                                   "Milena",
                                   new Battery("White", 300, 10, BatteryType.LiIon),
                                   new Display(8, 10080),
                                   new List<Call>());

            DateTime testCallDate1 = new DateTime(2015, 03, 30);
            DateTime testCallDate2 = new DateTime(2015, 03, 29);
            DateTime testCallDate3 = new DateTime(2015, 03, 28);

            DateTime testCallTime1 = DateTime.Parse("12:34:12");
            DateTime testCallTime2 = DateTime.Parse("13:55:01");
            DateTime testCallTime3 = DateTime.Parse("22:10:45");

            List<Call> testCalls = new List<Call>
            {
                new Call(testCallDate1, testCallTime1, "088234567", 40),
                new Call(testCallDate2, testCallTime2, "088675312", 60),
                new Call(testCallDate3, testCallTime3, "089245659", 100)
            };

            // Add few calls - using method AddCall(Call call) from the GSM class
            for (int i = 0; i < testCalls.Count; i++)
            {
                testGSM.AddCall(testCalls[i]);
            }

            // Display the information about the codes - using method PrintCallHistory() from the GSM class
            Console.WriteLine(testGSM.PrintCallHistory());

            // calculate and print the total price of the calls in the history using method CallPrice(decimal pricePerMin) from the GSM class
            decimal totalPrice = testGSM.CallPrice(Price);
            Console.WriteLine("Total price of test Calls - {0:F2}", totalPrice);

            // Remove the longest call from the history using method DeleteCall(Call call) from the GSM class
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration)
                                                       .ToArray()[testGSM.CallHistory.Count - 1];

            testGSM.DeleteCall(longestCall);

            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Largest call removed!");
            Console.WriteLine();
            Console.WriteLine(testGSM.PrintCallHistory());

            // cleare call history
            testGSM.ClearCallHistory();
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Calls history cleared!");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
            testGSM.ClearCallHistory();
        }
    }
}
