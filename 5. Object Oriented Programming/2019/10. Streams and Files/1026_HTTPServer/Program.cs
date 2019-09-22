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
            int port = 8080;
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            Console.WriteLine($"Server lisening on port {port}");
            while (true)
            {
                using (NetworkStream stream = listener.AcceptTcpClient().GetStream())
                {
                    // byte[] request = new byte[4096];
                    // stream.Read(request, 0, 4096);
                    // Console.WriteLine("Received: {0}", Encoding.UTF8.GetString(request));

                    // Pause
                    Thread.Sleep(1000);

                    StreamReader reader = new StreamReader("page.html");
                    byte[] html = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);

                    
                    // Console.WriteLine("Sended: {0}", Encoding.UTF8.GetString(html));
                }
            }
        }
    }
}
