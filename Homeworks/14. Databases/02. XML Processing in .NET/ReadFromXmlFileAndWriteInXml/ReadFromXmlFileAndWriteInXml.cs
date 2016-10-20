namespace ReadFromXmlFileAndWriteInXml
{
    using System;
    using System.Text;
    using System.Xml;

    public class ReadFromXmlFileAndWriteInXml
    {
        public static void Main(string[] args)
        {
            string fileName = "album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                writer.WriteAttributeString("name", "Catalogue");

                using (XmlReader reader = XmlReader.Create("../../../CreateCatalogue/catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                var albumName = reader.ReadElementContentAsString();
                                writer.WriteElementString("title", albumName);
                            }

                            if (reader.Name == "artist")
                            {
                                var artistName = reader.ReadElementContentAsString();
                                writer.WriteElementString("artist", artistName);
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();

                Console.WriteLine("Xml document \"{0}\" created in Debug folder.", fileName);
            }
        }
    }
}
