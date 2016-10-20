namespace ExtractArtists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    public class ExtractArtistsDom
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../CreateCatalogue/catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            Hashtable artists = new Hashtable();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;
                int key = 1;
                if (!artists.ContainsKey(artistName))
                {
                     artists.Add(node["artist"].InnerText, key);
                }
                else
                {
                    var lastValue = (int)artists[artistName];
                    artists[artistName] = ++lastValue;
                }
            }

            foreach (var artist in artists.Keys)
            {
                string state = ((int)artists[artist] > 1) ? "albums" : "album";
                Console.WriteLine("Artist - {0} has {1} {2} in catalogue.", artist, artists[artist], state);
            }
        }
    }
}
