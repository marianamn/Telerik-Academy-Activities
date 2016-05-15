using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number = ");
            int num = int.Parse(Console.ReadLine());

            string number = string.Format("{0,15:D}", num);
            string hexaDecimal = string.Format("{0,15:X}", num);
            string percentage = string.Format("{0,15:P}", num);
            string scientificNotation = string.Format("{0,15:E}", num);

            Console.WriteLine(number);
            Console.WriteLine(hexaDecimal);
            Console.WriteLine(percentage);
            Console.WriteLine(scientificNotation);
        }
    }
}
