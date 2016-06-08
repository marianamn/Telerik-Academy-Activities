namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        // problem 7
        private static string[] manufacturer = { "Nokia", "Samsung", "HTC" };

        private static string[] model = { "Lumnia", "N9", "S5", "One" };

        private static decimal[] price = { 1000m, 700.56m, 850.99m, 1700m };

        private static string[] owner = { "Ivan", "Georgi", "Dimitar", "Irina", "Anna" };

        private static Battery[] battery =
        {
            new Battery("New Battery", 250, 25, BatteryType.LiIon),
            new Battery("Bad Battery", 50, 5, BatteryType.NiCd),
            new Battery("Test Model", 300, 30, BatteryType.NiMH)
        };

        private static Display[] display =
        {
            new Display(4, 1000),
            new Display(5.5, 10000000)
        };

        public static GSM[] GenetareGSMs(int someNumber)
        {
            Random generator = new Random();
            GSM[] gsms = new GSM[someNumber];

            for (int i = 0; i < someNumber; i++)
            {
                gsms[i] = new GSM(
                                  manufacturer[generator.Next(0, manufacturer.Length)],
                                  model[generator.Next(0, model.Length)],
                                  price[generator.Next(0, price.Length)],
                                  owner[generator.Next(0, owner.Length)],
                                  battery[generator.Next(0, battery.Length)],
                                  display[generator.Next(0, display.Length)],
                                  new List<Call>());
            }

            return gsms;
        }

        public static void DisplayInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("Information about phone\n \n{0}", gsms[i]);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
            Console.WriteLine("IPhone Details");
            Console.WriteLine("\n{0}", GSM.Iphone4S);
            Console.WriteLine();
        }
    }
}
