namespace DeleteAlbumWithDom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class DeleteAlbumWithDom
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../CreateCatalogue/catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string albumPrice = node["price"].InnerText;
                decimal currentPrice = decimal.Parse(albumPrice);
                if (currentPrice > 20)
                {
                    node.RemoveAll();
                }
            }

            Console.WriteLine("Modified XML document:");
            Console.WriteLine(doc.OuterXml);

            doc.Save("../../modifiedCatalogue.xml");
        }
    }
}
