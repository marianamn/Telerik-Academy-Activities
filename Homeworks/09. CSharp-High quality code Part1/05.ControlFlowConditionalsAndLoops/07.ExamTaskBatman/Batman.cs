using System;

namespace _07.ExamTaskBatman
{
    public class Batman
    {
        private const char Space = ' ';

        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            PrintUpperPart(inputNumber, sign);
            PrintMiddlePart(inputNumber, sign);
            PrintLowerPart(inputNumber, sign);
        }

        private static void PrintUpperPart(int inputNumber, char sign)
        {
            int width = inputNumber * 3;
            int height = inputNumber / 2;

            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(Space, i));
                Console.Write(new string(sign, inputNumber - i));

                if (i == height - 1)
                {
                    Console.Write(new string(Space, (inputNumber - 3) / 2));
                    Console.Write(sign);
                    Console.Write(Space);
                    Console.Write(sign);
                    Console.Write(new string(Space, (inputNumber - 3) / 2));
                }
                else
                {
                    Console.Write(new string(Space, width - 2 * inputNumber));
                }

                Console.Write(new string(sign, inputNumber - i));
                Console.Write(new string(Space, i));
                Console.WriteLine();
            }
        }

        private static void PrintMiddlePart(int inputNumber, char sign)
        {
            int width = inputNumber * 3;
            int height = inputNumber / 3;

            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(Space, (width - (2 * inputNumber + 1)) / 2));
                Console.Write(new string(sign, 2 * inputNumber + 1));
                Console.Write(new string(Space, (width - (2 * inputNumber + 1)) / 2));
                Console.WriteLine();
            }
        }

        private static void PrintLowerPart(int inputNumber, char sign)
        {
            int width = inputNumber * 3;
            int height = inputNumber / 2;

            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(Space, (width - (inputNumber - 2)) / 2 + i));
                Console.Write(new string(sign, inputNumber - 2 - 2 * i));
                Console.Write(new string(Space, (width - (inputNumber - 2)) / 2 + i));
                Console.WriteLine();
            }
        }
    }
}
