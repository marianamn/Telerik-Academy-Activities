using System;

namespace ReadLargeCollectionOfProducts
{
    public class Product : IComparable
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Product otherProduct = obj as Product;
            if (otherProduct != null)
            {
                return this.Price.CompareTo(otherProduct.Price);
            }
            else
            {
                throw new ArgumentException("Object is not a Product");
            }
        }

        public override string ToString()
        {
            return string.Format("Product name: {0}, price: {1}", this.Name, this.Price + "\n");
        }
    }
}
