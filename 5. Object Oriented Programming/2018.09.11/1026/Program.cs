using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1026
{
    class Program
    {
        // TODO
        static void Main(string[] args)
        {
            // Transmission Control Protocol Server
            TcpListener server = new TcpListener(IPAddress.Loopback, 8081);
            server.Start();
            while (true)
            {
                // Transmission Control Protocol Client
                using (TcpClient client = server.AcceptTcpClient())
                {
                    // If Client Connects ...
                    Console.WriteLine("Connected!");
                    NetworkStream stream = client.GetStream();

                    // Send HTML Page to the Client
                    StreamReader reader = new StreamReader("page.html");
                    byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);

                    // 500 ms wait
                    Thread.Sleep(500);
                }
            }         
        }
    }
}
