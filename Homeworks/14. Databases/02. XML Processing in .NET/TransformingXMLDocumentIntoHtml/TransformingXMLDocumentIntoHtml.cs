namespace TransformingXMLDocumentIntoHtml
{
    using System;
    using System.Xml.Xsl;

    public class TransformingXMLDocumentIntoHtml
    {
        public static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../../CreateAnXSLStylesheet/catalogue.xsl");
            xslt.Transform("../../../CreateCatalogue/catalogue.xml", "catalog.html");
            Console.WriteLine("Html file created in Debug folder.");
        }
    }
}
