namespace ReadFromTxtFileAndWriteInXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class ReadFromTxtFileAndWriteInXml
    {
        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../personInfo.txt");
            using (reader)
            {
                var name = reader.ReadLine();
                var address = reader.ReadLine();
                var phoneNumber = reader.ReadLine();

                string fileName = "personInfo.xml";
                Encoding encoding = Encoding.GetEncoding("windows-1251");

                using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("persons");
                    writer.WriteAttributeString("name", "Persons-Catalogue");

                    writer.WriteStartElement("person");
                    writer.WriteElementString("name", name);
                    writer.WriteElementString("address", address);
                    writer.WriteElementString("phoneNumber", phoneNumber);
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                }

                Console.WriteLine("Xml document {0} created in Debug folder.", fileName);
            }   
        }
    }
}
