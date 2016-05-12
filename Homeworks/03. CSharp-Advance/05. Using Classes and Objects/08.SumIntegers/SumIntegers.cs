using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] input = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                sum = sum + numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
