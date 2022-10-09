using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace _109_HttpServer
{
    internal class Program
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
                    var request = Encoding.ASCII.GetString(requestBytes);
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
                                code = code.Replace("{Date}", $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}, {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
                                code = code.Replace("{CPU}", Environment.ProcessorCount.ToString());
                                break;
                            }
                        default:
                            {
                                reader = new StreamReader("page.html");
                                code = reader.ReadToEnd();
                                break;
                            }
                    }

                    // Form the response
                    StringBuilder message = new StringBuilder();
                    message.Append("HTTP/1.1 200 OK\r\n");
                    message.Append("Content-Type: text/html\r\n");
                    message.Append("Content-Length: " + code.Length + "\r\n\r\n");
                    message.Append(code);

                    // Return Response to Client
                    byte[] bytes = Encoding.ASCII.GetBytes(message.ToString());
                    stream.Write(bytes, 0, bytes.Length);

                    // Clean Up
                    stream.Flush();
                    stream.Close();
                }
            }
        }
    }
}