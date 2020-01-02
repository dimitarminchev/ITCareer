using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PostSample
{
    class Program
    {
        // Post
        public static string Post(string uri, string data, string contentType, string method = "POST")
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = contentType;
            request.Method = method;

            using (var requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }

            // Request Headers
            Console.WriteLine("Request Headers:");
            foreach (var headerItem in request.Headers)
            {

                IEnumerable<string> values;
                string HeaderItemValue = "";
                values = request.Headers.GetValues(headerItem.ToString());
                foreach (var valueItem in values)
                {
                    HeaderItemValue = HeaderItemValue + valueItem + ";";
                }
                Console.WriteLine(headerItem + " : " + HeaderItemValue);
            }
            Console.WriteLine();

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                // Response Headers
                Console.WriteLine("Response Headers:");
                foreach (var headerItem in response.Headers)
                {
                    IEnumerable<string> values;
                    string HeaderItemValue = "";
                    values = response.Headers.GetValues(headerItem.ToString());
                    foreach (var valueItem in values)
                    {
                        HeaderItemValue = HeaderItemValue + valueItem + ";";
                    }
                    Console.WriteLine(headerItem + " : " + HeaderItemValue);
                }
                Console.WriteLine();

                // Return
                return reader.ReadToEnd();
            }
        }


        // Main
        static void Main(string[] args)
        {
            var html = Post("http://www.dir.bg", "q=burgas", "text/html", "POST");
            Console.WriteLine(html.Substring(0,1024));
        }
    }
}
