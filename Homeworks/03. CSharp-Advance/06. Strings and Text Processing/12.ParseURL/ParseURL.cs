namespace _12.ParseURL
{
    using System;
    using System.Text;

    class ParseURL
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            string protocol = url.Substring(0, 4);
            Console.WriteLine("[protocol]={0}", protocol);
            url = url.Remove(0, protocol.Length + 3);
            result.Append(url);

            string dotCom = ".com";
            int indexDotCom = url.IndexOf(dotCom);
            string server = url.Substring(0, indexDotCom + 4);
            Console.WriteLine("[server]={0}", server);

            url = url.Remove(0, server.Length);
            result.Append(url);

            Console.WriteLine("[resource]={0}", url);
        }
    }
}
