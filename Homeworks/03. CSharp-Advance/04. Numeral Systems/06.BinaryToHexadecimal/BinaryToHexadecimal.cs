namespace _06.BinaryToHexadecimal
{
    using System;

    public class BinaryToHexadecimal
    {
        public static void Main()
        {
            string binary = Console.ReadLine();

            string binaryToHexadecimal = ConvertBinaryToHexadecimal(binary);

            Console.WriteLine(binaryToHexadecimal);
        }

        private static string ConvertBinaryToHexadecimal(string binary)
        {
            string number = string.Empty;

            if (binary.Length % 4 != 0)
            {
                binary = new string('0', 4 - binary.Length % 4) + binary;
            }

            for (int i = 0; i < binary.Length; i+=4)
            {
                string num = binary.Substring(i, 4);

                switch (num)
                {
                    case "0000": number += "0"; break;
                    case "0001": number += "1"; break;
                    case "0010": number += "2"; break;
                    case "0011": number += "3"; break;
                    case "0100": number += "4"; break;
                    case "0101": number += "5"; break;
                    case "0110": number += "6"; break;
                    case "0111": number += "7"; break;
                    case "1000": number += "8"; break;
                    case "1001": number += "9"; break;
                    case "1010": number += "A"; break;
                    case "1011": number += "B"; break;
                    case "1100": number += "C"; break;
                    case "1101": number += "D"; break;
                    case "1110": number += "E"; break;
                    case "1111": number += "F"; break;
                }
            }

            return number;
        }
    }
}
