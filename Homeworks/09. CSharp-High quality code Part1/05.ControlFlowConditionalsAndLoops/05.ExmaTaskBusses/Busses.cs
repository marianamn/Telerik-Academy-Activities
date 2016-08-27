using System;

namespace _05.ExmaTaskBusses
{
    public class Busses
    {
        public static void Main()
        {
            // reading input data
            int numberOfBuses = int.Parse(Console.ReadLine());
            int[] speeds = new int[numberOfBuses];

            for (int i = 0; i < numberOfBuses; i++)
            {
                speeds[i] = int.Parse(Console.ReadLine());
            }

            int count = 1;

            for (int i = 0; i < speeds.Length - 1; i++)
            {
                if (speeds[i] >= speeds[i + 1])
                {
                    count++;
                }
                else
                {
                    speeds[i + 1] = speeds[i];
                }
            }

            Console.WriteLine(count);
        }
    }
}
