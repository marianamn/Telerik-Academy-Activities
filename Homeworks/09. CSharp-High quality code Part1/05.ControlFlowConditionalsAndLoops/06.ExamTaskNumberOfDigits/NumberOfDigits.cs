using System;

namespace _06.ExamTaskNumberOfDigits
{
    public class NumberOfDigits
    {
        public static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int countDigits = 0;

            for (int i = 1; i <= pages; i++)
            {
                string page = Convert.ToString(i);
                int pageLenght = page.Length;

                switch (pageLenght)
                {
                    case 1: countDigits += 1; break;
                    case 2: countDigits += 2; break;
                    case 3: countDigits += 3; break;
                    case 4: countDigits += 4; break;
                    case 5: countDigits += 5; break;
                    case 6: countDigits += 6; break;
                }
            }

            Console.WriteLine(countDigits);
        }
    }
}
