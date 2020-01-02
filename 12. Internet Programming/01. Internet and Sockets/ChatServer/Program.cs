using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            string message = "";
            try
            {
                byte[] buffer = new byte[1024];

                listener.Bind(localEndPoint);
                listener.Listen(100);

                Socket handle = listener.Accept();

                while (true)
                {
                    message = "";

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

                    Console.WriteLine("> " + message);

                    if (message == "exit")
                    {
                        handle.Shutdown(SocketShutdown.Both);

                        handle.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            Console.WriteLine("Goodbye");
            Console.ReadKey(true);
        }
    }
}
