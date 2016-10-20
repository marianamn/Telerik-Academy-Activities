namespace ExtractPriceWithLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class ExtractPriceWithLINQ
    {
        internal const int CurrentYear = 2016;

        public static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../CreateCatalogue/catalogue.xml");

            var prices = from album in xmlDoc.Descendants("album")
                         where int.Parse(album.Element("year").Value) < (CurrentYear - 5)
                             select new
                             {
                                Price = album.Element("price").Value
                             };

            foreach (var price in prices)
            {
                Console.WriteLine(price.Price);
            }
        }
    }
}
