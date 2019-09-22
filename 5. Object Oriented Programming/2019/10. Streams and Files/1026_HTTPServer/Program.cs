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

                    var page = request.Substring( request.IndexOf("/") + 1, request.IndexOf("HTTP/1.1") - request.IndexOf("/") - 1);
                    if (string.IsNullOrEmpty(page.Trim())) page = "page.html"; // Default Page

                    // Send to clilent
                    StreamReader reader = new StreamReader(page);
                    byte[] html = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);
                }
            }
        }
    }
}
