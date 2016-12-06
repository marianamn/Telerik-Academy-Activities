using System;
using System.Text;

namespace ReadLargeCollectionOfProducts
{
    public class RandomGenerator
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

        private static Random random = new Random();

        public static int GetRandomPrice(int min = 1, int max = 500)
        {
            return random.Next(min, max + 1);
        }

        public static string GetRandomProduct(int minLength = 0, int maxLength = int.MaxValue / 2)
        {
            var length = random.Next(minLength, maxLength);

            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(alphabet[random.Next(0, alphabet.Length)]);
            }

            return result.ToString();
        }
    }
}