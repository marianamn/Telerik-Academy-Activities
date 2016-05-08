namespace _09.BinaryFloatingPoint
{
    using System;

    public class BinaryFloatingPoint
    {
        public static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());

            string inputToBinary = FloatToBinary(input);
            Console.WriteLine(inputToBinary.Substring(1, 21));

            //Pthe first bit is the sign, the next 8 bits are the exponent, the rest are the mantissa 
            //Console.WriteLine("Number: {0}\nSign: {1} Exponent: {2} Mantissa: {3}", input, inputToBinary[0],
            //    inputToBinary.Substring(1, 8), inputToBinary.Substring(9, 22));
        }

        public static string FloatToBinary(float number)
        {
            byte[] bytesInput = BitConverter.GetBytes(number);
            string inputToBinary = string.Empty;

            //convert each byte to its binary representation and pad with zeroes to get 8 bits for each byte 
            for (int i = 0; i < bytesInput.Length; i++)  
            {                                            
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }

            return inputToBinary;
        }
    }
}