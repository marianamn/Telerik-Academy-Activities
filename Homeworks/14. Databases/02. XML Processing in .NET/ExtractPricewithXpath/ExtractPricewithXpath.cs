namespace ExtractPricewithXpath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractPriceWithXpath
    {
        internal const int CurrentYear = 2016;

        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../CreateCatalogue/catalogue.xml");
            string xPathQuery = "/catalogue/album";

            List<decimal> prices = new List<decimal>();

            XmlNodeList albumList = doc.SelectNodes(xPathQuery);
            foreach (XmlNode node in albumList)
            {
                var albumYear = node.SelectSingleNode("year").InnerText;
                int currentAlbumYear = int.Parse(albumYear);
                if (currentAlbumYear < (CurrentYear - 5))
                {
                    decimal price = decimal.Parse(node["price"].InnerText);
                    prices.Add(price);
                }
            }

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
