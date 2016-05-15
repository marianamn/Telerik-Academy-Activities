namespace _05.ParseTags
{
    using System;
    using System.Text;

    public class ParseTags
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string openTag = "<upcase>";
            string closeTag = "</upcase>";

            int startIndex = text.IndexOf(openTag);
            int endIndex = text.IndexOf(closeTag);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - openTag.Length && text.Substring(i, openTag.Length) == openTag)
                {
                    string textToUpper = text.Substring(startIndex + openTag.Length, endIndex - startIndex - openTag.Length).ToUpper();
                    result.Append(textToUpper);

                    startIndex = text.IndexOf(openTag, startIndex + 1);
                    endIndex = text.IndexOf(closeTag, endIndex + 1);

                    i += openTag.Length + textToUpper.Length + closeTag.Length;
                }

                result.Append(text[i]);
            }

            result = result.Replace(openTag, "");
            result = result.Replace(closeTag, "");

            Console.WriteLine(result);
        }
    }
}
