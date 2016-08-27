using System;

namespace _01.Chef
{
    public class Startup
    {
        public static void Main()
        {
            // Task 1
            var chef = new Chef();
            var bowl = chef.Cook();
            Console.WriteLine(bowl);

            // Task 2
            Potato potato = new Potato();

            if (potato != null)
            {
                // if (!potato.IsPeeled && !potato.IsRotted)
                if (potato.IsPeeled && potato.IsRotted)
                {
                    chef.Cook();
                    Console.WriteLine(bowl);
                }
                else
                {
                    Console.WriteLine("Poato has not been peeled, so it can not be cooked");
                }
            }
        }
    }
}
