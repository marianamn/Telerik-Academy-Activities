namespace _08.BinaryShort
{
    using System;

    public class BinaryShort
    {
        public static void Main()
        {
            short input = short.Parse(Console.ReadLine());

            string inputToBinary = ShortToBinary(input);

            // the first bit is the sign (0 for positive, 1 for negative), the next 15 bits are for the number  
            Console.WriteLine(inputToBinary.Substring(1, 15));
        }

        public static string ShortToBinary(short number)
        {
            // get the number as an array of 4 bytes 
            byte[] bytesInput = BitConverter.GetBytes(number); 
            string inputToBinary = string.Empty;

            // convert each byte to its binary representation and pad with zeroes to get 8 bits for each byte 
            for (int i = 0; i < bytesInput.Length; i++)
            {                                       
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }

            return inputToBinary;
        }
    }
}