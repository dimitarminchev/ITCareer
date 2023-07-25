using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000); // ip:port

            // TCP = SocketType.Stream, UDP = SocketType.Dgram
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEP);
                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                while (true)
                {
                    Console.Write("> ");
                    string message = Console.ReadLine();
                    byte[] msg = Encoding.ASCII.GetBytes(message + "<EOF>");

                    int bytesSent = sender.Send(msg);

                    if (message == "exit")
                        break;
                }

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
