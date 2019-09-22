using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _05_NetworkStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Server start
            var portNumber = 8080;
            var tcpListener = new TcpListener(IPAddress.Any, portNumber);
            tcpListener.Start();
            Console.WriteLine("Listening on port {0}...", portNumber);

            while (true)
            {
                using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    // Read from the Connected Client
                    byte[] request = new byte[4096];
                    stream.Read(request, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(request));

                    // Prepare HTML to send
                    string bulgarianDate = string.Format($"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} г., {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} ч. ");
                    string html = string.Format("<html><head><meta charset=\"UTF-8\" /></head><body><h1>Добре дошли!</h1><hr /><h2>{0}</h2><p>Ние сме групата в Сливен.</p></body></html>", bulgarianDate);
                    byte[] htmlBytes = Encoding.UTF8.GetBytes(html);

                    // Write to tha connected client
                    stream.Write(htmlBytes, 0, htmlBytes.Length);
                }
            }
        }
    }
}
