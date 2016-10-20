namespace CreteXSDSchema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class CreteXSDSchema
    {
        public static void Main(string[] args)
        {
            var schema = new XmlSchemaSet();
            schema.Add(null, "../../catalogue.xsd");

            var catalogue = XDocument.Load("../../../CreateCatalogue/catalogue.xml");

            ValidateXMLAgainstSchema(catalogue, schema);
        }

        private static void ValidateXMLAgainstSchema(XDocument xmlDoc, XmlSchemaSet schema)
        {
            bool errors = false;

            xmlDoc.Validate(
                schema, (o, ev) =>
            {
                Console.WriteLine(ev.Message);
                errors = true;
            });

            Console.WriteLine("Xml file {0} against catalogueSchema.xsd", errors ? "did not validate" : "validated");
        }
    }
}
