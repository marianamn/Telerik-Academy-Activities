using System;
using System.Linq;

namespace _04.ExamTaskDancingMoves
{
    public class DancingMoves
    {
        public static void Main()
        {
            long[] numbers = ParseArrayOfNumbers(); 
            
            string[] line = new string[2];
            long time = 0;
            string direction = string.Empty;
            long step = 0;
            long position = 0;
            long sum = 0;
            long count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                line = input.Split(' ');
                time = long.Parse(line[0]);
                direction = line[1];
                step = long.Parse(line[2]);

                for (int i = 0; i < time; i++)
                {
                    position = CalculateNextPosition(position, direction, step, numbers.Length);
                    
                    sum += numbers[position];
                }

                count++;
            }

            double avrg = (double)(sum) / count;

            Console.WriteLine("{0:F1}", avrg);
        }

        private static long[] ParseArrayOfNumbers()
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            return numbers;
        }

        private static long CalculateNextPosition(long position, string direction, long step, int arrayLength)
        {
            if (direction == "right")
            {
                position = (position + step) % arrayLength;
            }
            else
            {
                position = (arrayLength + position - step % arrayLength) % arrayLength;
            }

            return position;
        }
    }
}
