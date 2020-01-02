using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetSample
{
    class Program
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="uri">Unified Resource Identifier</param>
        /// <returns>Responce String</returns>
        public static string Get(string uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                // Headers
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

                // Return
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">Arguments</param>
        static void Main(string[] args)
        {
            var html = Get("http://www.dir.bg");
            Console.WriteLine(html.Substring(0, 512));
        }
    }
}
