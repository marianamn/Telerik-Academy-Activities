namespace DownloadFile
{
    using System;
    using System.Net;

    public class DownloadFile
    {
        public static void Main()
        {
            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"news-img01.png");
                Console.WriteLine("Done");//the image should be saved in /bin/Debug folder
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null");
            }
            catch (WebException)
            {
                Console.WriteLine("File does not exist, its name is null or empty, address is invalid, or an error occurred while downloading data");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}
