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
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 8081);
            server.Start();
            while (true)
            {
                using (TcpClient client = server.AcceptTcpClient())
                {                    
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader("page.html");
                    byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                    stream.Write(html, 0, html.Length);
                    Thread.Sleep(500);
                }
            }         
        }
        /*   // V2
             static void Main(string[] args)
             {
                 TcpListener server = new TcpListener(IPAddress.Loopback, 8081);
                 server.Start();
                 while (true)
                 {
                     using (TcpClient client = server.AcceptTcpClient())
                     {
                         Console.WriteLine("Connected!");
                         NetworkStream stream = client.GetStream();
                         byte[] bytes = new byte[256];
                         int i = stream.Read(bytes, 0, bytes.Length);
                         List<string> data = Encoding.ASCII.GetString(bytes, 0, bytes.Length).Split('\n').ToList();
                         string page = data[0].Split()[1];
                         switch (page)
                         {
                             case "/":
                                 {
                                     StreamReader reader = new StreamReader("page.html");
                                     byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                                     stream.Write(html, 0, html.Length);
                                     break;
                                 }
                             case "/info":
                                 {
                                     StreamReader reader = new StreamReader("info.html");
                                     byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                                     stream.Write(html, 0, html.Length);
                                     break;
                                 }
                             default:
                                 {
                                     StreamReader reader = new StreamReader("error.html");
                                     byte[] html = Encoding.Unicode.GetBytes(reader.ReadToEnd());
                                     stream.Write(html, 0, html.Length);
                                     break;
                                 }
                         }
                         Thread.Sleep(500);
                     }
                 }         
             }    
              */
    }
}
