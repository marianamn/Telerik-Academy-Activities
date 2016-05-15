namespace _09.ForbiddenWords
{
    using System;
    using System.Text;

    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text:");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter forbidden words, separated by comma and space:");
            string[] forbbidenWords = Console.ReadLine().Trim().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < forbbidenWords.Length; j++)
                {
                    if ((i < text.Length - forbbidenWords[j].Length)
                        && text.Substring(i, forbbidenWords[j].Length) == forbbidenWords[j])
                    {
                        text = text.Remove(i, forbbidenWords[j].Length);
                        result.Append('*', forbbidenWords[j].Length);
                    }
                    else
                    {
                        continue;
                    }
                }
                result.Append(text[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Resulted text:\n{0}", result);
        }
    }
}
