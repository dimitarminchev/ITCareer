using System.Net.Sockets;
using System.Net;
using System.Text;

namespace _05_NetworkStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Create TCP network connection listener
            int portNumber = 8080;
            var tcpListener = new TcpListener(IPAddress.Any, portNumber);
            tcpListener.Start();
            Console.WriteLine("Listening on port {0}...", portNumber);

            while (true)
            {
                // Step 2. Accept TCP network client
                using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    // Step 3. Read from client
                    byte[] request = new byte[4096];
                    stream.Read(request, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(request));

                    // step 4. Srite to client
                    string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}",
                      "<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);
                    byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
                    stream.Write(htmlBytes, 0, htmlBytes.Length);

                    /* TODO: Test it!
                     string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}",
                                          "<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);

                                        StringBuilder message = new StringBuilder();
                                        message.Append("HTTP/1.1 200 OK\r\n");
                                        message.Append("Content-Type: text/html\r\n");
                                        message.Append("Content-Length: " + html.Length + "\r\n\r\n");
                                        message.Append(html);

                                        byte[] bytes = Encoding.ASCII.GetBytes(message.ToString());
                                        stream.Write(bytes, 0, bytes.Length);
                    */


                    // TODO: HttpResponse => http://192.168.0.100:8080
                }
            }
        }
    }
}