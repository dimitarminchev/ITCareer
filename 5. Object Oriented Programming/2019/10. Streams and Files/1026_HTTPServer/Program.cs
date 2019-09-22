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
                    Thread.Sleep(1000); // Pause to process the request

                    StreamReader reader = new StreamReader("page.html");
                    byte[] html = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);
                }
            }
        }
    }
}
