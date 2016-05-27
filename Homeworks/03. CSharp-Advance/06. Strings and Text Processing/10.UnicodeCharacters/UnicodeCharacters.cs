namespace _10.UnicodeCharacters
{
    using System;
    using System.Globalization;
    using System.Text;
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Convert.ToString(input, CultureInfo.InvariantCulture);


            for (int i = 0; i < text.Length; i++)
            {
                string eachChar = string.Format("\\u{0:X4}", Convert.ToUInt16(text[i]));
                Console.Write(eachChar);
            }

            Console.WriteLine();
        }
    }
}
