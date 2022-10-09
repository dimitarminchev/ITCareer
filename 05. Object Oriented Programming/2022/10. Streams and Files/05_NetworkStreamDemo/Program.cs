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
            Console.WriteLine("http://127.0.0.1:8080/");
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            while (true)
            {
                // Step 2. Accept TCP network client
                using (NetworkStream stream = listener.AcceptTcpClient().GetStream())
                {
                    // Step 3. Read 4K from client
                    byte[] request = new byte[4096];
                    stream.Read(request, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(request));

  
                    // Step 4. HTML
                    string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}","<html>","<body>","<h1>","Welcome to my awesome site!", DateTime.Now);
                    // Step 5. Prepare the responce to the client
                    StringBuilder message = new StringBuilder();
                    message.Append("HTTP/1.1 200 OK\r\n");
                    message.Append("Content-Type: text/html\r\n");
                    message.Append("Content-Length: " + html.Length + "\r\n\r\n");
                    message.Append(html);

                    // Step 6. Send the response to client
                    byte[] bytes = Encoding.ASCII.GetBytes(message.ToString());
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}