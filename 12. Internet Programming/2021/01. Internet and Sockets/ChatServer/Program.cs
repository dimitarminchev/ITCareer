using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    class Program
    {
        // Socket Server
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] buffer = new byte[1024];
                listener.Bind(localEndPoint);
                listener.Listen(100);

                Socket handle = listener.Accept();

                while (true)
                {
                    string message = "";
                    while (true)
                    {
                        int messageSize = handle.Receive(buffer);
                        message += Encoding.ASCII.GetString(buffer, 0, messageSize);
                        if (message.Contains("<EOF>"))
                        {
                            message = message.Replace("<EOF>", "");
                            break;
                        }
                    }
                    Console.WriteLine("> {0}", message);

                    if (message == "exit")
                    {
                        handle.Shutdown(SocketShutdown.Both);
                        handle.Close();
                        break; 
                    }

                    // echo
                    handle.Send(Encoding.ASCII.GetBytes(message + "<EOF>"));
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.Clear();
            Console.WriteLine("Goodbye");
            Console.ReadKey(true);
        }
    }
}
