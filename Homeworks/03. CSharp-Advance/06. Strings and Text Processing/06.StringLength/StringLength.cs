namespace _06.StringLength
{
    using System;

    public class StringLength
    {
        private const int LengthNeeded = 20;
        private const char CharToAdd = '*';

        public static void Main()
        {
            string text = Console.ReadLine();
            int length = text.Length;

            int differenceInlength = LengthNeeded - length;

            if (differenceInlength > 0 )
            {
                Console.WriteLine(text.PadRight(LengthNeeded, CharToAdd));
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}
