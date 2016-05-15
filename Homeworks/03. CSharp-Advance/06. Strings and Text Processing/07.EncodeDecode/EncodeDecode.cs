namespace _07.EncodeDecode
{
    using System;
    using System.Text;

    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to be encoded: ");
            string input = Console.ReadLine();

            Console.Write("Enter encryption key: ");
            string cipher = Console.ReadLine();

            var encodedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                encodedInput.Append((char)(input[i] ^ cipher[i % cipher.Length])); //encoding 
            }

            Console.WriteLine("Encoded text: {0}", encodedInput);


            var decodedText = new StringBuilder();
            for (int i = 0; i < encodedInput.Length; i++)
            {
                decodedText.Append((char)(encodedInput[i] ^ cipher[i % cipher.Length])); //decoding 
            }

            Console.WriteLine("Decoded text: {0}", decodedText);
        }
    }
}
