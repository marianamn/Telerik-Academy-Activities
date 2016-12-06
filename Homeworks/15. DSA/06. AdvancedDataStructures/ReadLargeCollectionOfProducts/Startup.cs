// Write a program to read a large collection of products(name + price) and efficiently find the first 20 products in the price range[a…b].
// Test for 500 000 products and 10 000 price searches.
// Hint: you may use OrderedBag<T> and sub-ranges.

using System;
using Wintellect.PowerCollections;

namespace ReadLargeCollectionOfProducts
{
    public class Startup
    {
        public static void Main()
        {
            // Tested with smaller numbers
            const int ProductsNimber = 50; // 500000
            const int PriceNimber = 30; // 10000
            const int FirtstTwentyProducts = 20;
            const decimal PriceRangeFrom = 0.01m;
            const decimal PriceRangeTo = 200m;

            OrderedBag<Product> products = new OrderedBag<Product>();
            OrderedBag<Product> productsInPriceRange = new OrderedBag<Product>();

            for (int i = 0; i < ProductsNimber; i++)
            {
                products.Add(new Product(RandomGenerator.GetRandomProduct(3, 6), RandomGenerator.GetRandomPrice()));
            }

            for (int j = 0; j < PriceNimber; j++)
            {
                if (PriceRangeFrom <= products[j].Price && products[j].Price <= PriceRangeTo)
                {
                    productsInPriceRange.Add(products[j]);
                }

                if (productsInPriceRange.Count == FirtstTwentyProducts)
                {
                    break;
                }
            }

            Console.WriteLine("Products bag:\n{0}", products.ToString());
            Console.WriteLine("First 20 products with price in range [1 - 200]:\n{0}", productsInPriceRange.ToString());
        }
    }
}
