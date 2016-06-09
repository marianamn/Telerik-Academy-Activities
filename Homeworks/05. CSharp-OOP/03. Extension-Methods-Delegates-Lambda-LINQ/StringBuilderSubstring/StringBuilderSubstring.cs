using System;
using System.Text;

namespace StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring (this StringBuilder str, int index, int length)
        {
            string text = str.ToString();

            var result = new StringBuilder(length);

            if (index < 0 || index > text.Length - 1 )
            {
                throw new ArgumentOutOfRangeException("Index must be greater or equal to 0 and less than text length");
            }

            if (length < 0 || (index + length) > text.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Text length should be greater than 0 and index + substring length must be less than text length");
            }


            for (int i = index; i < index+length; i++)
            {
                result.Append(str[i]);
            }
            return result;
        }
    }
}
