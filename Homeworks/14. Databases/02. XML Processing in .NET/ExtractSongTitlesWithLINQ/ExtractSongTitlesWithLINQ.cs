namespace ExtractSongTitlesWithLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractSongTitlesWithLINQ
    {
        public static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../CreateCatalogue/catalogue.xml");

            var songTitles = from song in xmlDoc.Descendants("song")
                            select new
                            {
                                Title = song.Element("title").Value
                            };

            foreach (var songTitle in songTitles)
            {
                Console.WriteLine(songTitle.Title);
            }
        }
    }
}
