namespace _10.UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            for (int i = 0; i < text.Length; i++)
            {
                string eachChar = string.Format("\\u{0:X4}", Convert.ToUInt16(text[i]));
                Console.Write(eachChar);
            }

            Console.WriteLine();
        }
    }
}
