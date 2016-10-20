using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProcessingJsonInDotNET
{
    public class ProcessingJsonInDotNET
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var url = " https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var rssContent = ReadingRSS(url);

            var jsonVideos = ConvertRssToJson(rssContent);

            PrintAllVideosTitles(jsonVideos);

            var videos = GetVideos(jsonVideos);
            GenerateHtml(videos);

            Console.WriteLine("Html file created in the main project folder!");
        }

        private static string ReadingRSS(string url)
        {
            var webClient = new WebClient();
            var rss = webClient.DownloadData(url);
            var rssContent = Encoding.UTF8.GetString(rss);

            return rssContent;
        }

        private static string ConvertRssToJson(string rssContent)
        {
            var doc = new XmlDocument();
            doc.LoadXml(rssContent);
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);

            return json;
        }

        private static void PrintAllVideosTitles(string jsonVideos)
        {
            var jsonObj = JObject.Parse(jsonVideos);
            var videoTitles = jsonObj["feed"]["entry"].Select(m => m["title"]);

            var indexer = 1;
            foreach (var title in videoTitles)
            {
                Console.WriteLine("{0} - {1}", indexer, title);
                indexer++;
            }
        }

        private static IEnumerable<Video> GetVideos(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["feed"]["entry"]
                   .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));
        }

        private static void GenerateHtml(IEnumerable<Video> videos)
        {
            var html = "<!DOCTYPE html><html><head><meta charset=\"utf-8\" /></head><body>";

            foreach (var video in videos)
            {
                html += string.Format(
                                  "<div style=\"float:left; width: 400px; height: 430px; padding:10px;" +
                                  "margin:5px; background-color:#689B31; color:white; border-radius:10px\">" +
                                  "<iframe width=\"400\" height=\"325\" " +
                                  "src=\"http://www.youtube.com/embed/{2}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{1}</h3><a href=\"{0}\"></a></div></html>",
                                  video.Link.Href, 
                                  video.Title, 
                                  video.Id);
            }

            html += "</body></html>";

            File.WriteAllText("../../index.html", html);
        }
    }
}
