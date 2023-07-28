using System;
using System.IO;
using System.Net;

namespace GetSample
{
    class Program
    {
        // Get 
        public static string Get(string uri)
        {
            // Rwquest
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            // Response
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                Console.WriteLine("Headers:\n{0}", response.Headers);
                return reader.ReadToEnd();
            }
        }

        // Main
        static void Main(string[] args)
        {
            var html = Get("http://www.dir.bg");
            Console.WriteLine("Contents:\n{0}", html.Substring(0, 512));
        }
    }
}
