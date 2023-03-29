using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace HttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Create TCP network connection listener
            Console.WriteLine("http://127.0.0.1:8080/");
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            while (true)
            {
                // Step 2. Accept TCP network client
                using (NetworkStream stream = listener.AcceptTcpClient().GetStream())
                {
                    // Step 3. Read 4K bytes 
                    byte[] requestBytes = new byte[4096];
                    stream.Read(requestBytes, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(requestBytes));

                    // Step 4. Find requested page
                    var requestString = Encoding.ASCII.GetString(requestBytes);
                    string page = string.Empty;
                    try
                    {
                        page = requestString.Substring(requestString.IndexOf("/") + 1, requestString.IndexOf("HTTP/") - requestString.IndexOf("/") - 1).Trim();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }

                    // Step 5. Read html page
                    StreamReader reader = null;
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

                    // Step 6. Form the response
                    StringBuilder message = new StringBuilder();
                    message.Append("HTTP/1.1 200 OK\r\n");
                    message.Append("Content-Type: text/html\r\n");
                    message.Append("Content-Length: " + code.Length + "\r\n\r\n");
                    message.Append(code);

                    // Step 7. Return Response to Client
                    byte[] bytes = Encoding.ASCII.GetBytes(message.ToString());
                    stream.Write(bytes, 0, bytes.Length);

                    // Step 8. Clean Up
                    stream.Flush();
                    stream.Close();
                }
            }
        }
    }
}