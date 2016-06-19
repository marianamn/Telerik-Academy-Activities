namespace _01.StringBuilderExtention
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var result = new StringBuilder(length);

            var text = str.ToString();

            if (index < 0 || index > text.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index must be greater or equal to 0 and less than text length");
            }

            if (length < 0 || (index + length) > text.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Text length should be greater than 0 and index plus substring length must be less than text length");
            }

            for (int i = index; i < index + length; i++)
            {
                result.Append(text[i]);
            }

            return result;
        }
    }
}
