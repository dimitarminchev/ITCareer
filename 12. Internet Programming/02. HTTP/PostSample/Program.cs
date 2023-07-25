using System;
using System.IO;
using System.Net;
using System.Text;

namespace PostSample
{
    class Program
    {
        // Post
        public static string Post(string uri, string data, string contentType, string method = "POST")
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            // Request
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = contentType;
            request.Method = method;
            using (var requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }
            Console.WriteLine("Request Headers:\n{0}", request.Headers);

            // Response
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                Console.WriteLine("Response Headers:\n{0}", response.Headers);
                return reader.ReadToEnd();
            }
        }

        // Main
        static void Main(string[] args)
        {
            var html = Post("http://www.dir.bg", "q=burgas", "text/html", "POST");
            Console.WriteLine("Response Contents:\n{0}", html.Substring(0,512));
        }
    }
}
