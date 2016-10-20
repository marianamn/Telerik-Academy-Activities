namespace ExtractSongTitlesWithXmlReader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractSongTitlesWithXmlReader
    {
        public static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../../CreateCatalogue/catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }
        }
    }
}
