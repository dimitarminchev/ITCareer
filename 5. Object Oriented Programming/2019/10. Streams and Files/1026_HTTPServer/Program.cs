using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
                using (TcpClient client = listener.AcceptTcpClient())
                {
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader("page.html");
                    byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);
                }
            }
        }
    }
}
