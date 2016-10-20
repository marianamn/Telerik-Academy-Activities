namespace TraverseDirectory2
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml.Linq;

    class TraverseDirectory
    {
        static void Main(string[] args)
        {
            var result = new XElement("directory");
            result.Add(TraverseDirectories("../../"));
            result.Save("../../result.xml");

            Console.WriteLine("Genereted result.xml in the main directory of the project");
        }

        private static XElement TraverseDirectories(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraverseDirectories(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file", new XAttribute("name", Path.GetFileName(file))));
            }

            return element;
        }
    }
}