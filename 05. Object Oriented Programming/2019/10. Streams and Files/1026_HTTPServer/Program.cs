using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1026_HTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("http://127.0.0.1:8080/");
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            while (true)
            {
                using (NetworkStream stream = listener.AcceptTcpClient().GetStream())
                {

                    byte[] requestBytes = new byte[4096];
                    stream.Read(requestBytes, 0, 4096);
                    var request = Encoding.UTF8.GetString(requestBytes);
                    string page = string.Empty;
                    try
                    {
                        page = request.Substring(request.IndexOf("/") + 1, request.IndexOf("HTTP/") - request.IndexOf("/") - 1).Trim();
                    }
                    catch
                    {
                        Console.WriteLine("Error reading page data.");
                    }
                    StreamReader reader;
                    string code = string.Empty;
                    switch (page)
                    {
                        case "page.html":
                        case "error.html":
                            {
                                reader = new StreamReader(page);
                                code = reader.ReadToEnd();
                                break;
                            }

                        case "info.html":
                            {
                                reader = new StreamReader(page);
                                code = reader.ReadToEnd();
                                code = code.Replace("{Date}", $"{ DateTime.Now.Day}.{ DateTime.Now.Month}.{ DateTime.Now.Year}, { DateTime.Now.Hour}:{ DateTime.Now.Minute}:{ DateTime.Now.Second}");
                                code = code.Replace("{CPU}",Environment.ProcessorCount.ToString());
                                break;
                            }
                        default:
                            {
                                reader = new StreamReader("page.html");
                                code = reader.ReadToEnd();
                                break;
                            }
                    } 

                    // Send to clilent
                    byte[] html = Encoding.UTF8.GetBytes(code.Replace("\r",""));
                    stream.Write(html, 0, html.Length);
                }
            }
        }
    }
}
