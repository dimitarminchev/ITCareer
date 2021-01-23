using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MiniServer.WebServer
{
    public class Server
    {
        private const string LocalhostIpAddress = "127.0.0.1";

        private readonly int port;

        private readonly TcpListener listener;

        private readonly IServerRoutingTable serverRoutingTable;

        private bool isRunning;

        public Server(int port, IServerRoutingTable serverRoutingTable)
        {
            this.port = port;
            this.listener = new TcpListener(IPAddress.Parse(LocalhostIpAddress), port);
            this.serverRoutingTable = serverRoutingTable;
        }

        public void Run()
        {
            this.listener.Start();
            this.isRunning = true;
            Console.WriteLine($"Server started at http://{LocalhostIpAddress}:{this.port}");
            while (this.isRunning)
            {
                Console.WriteLine("Waiting for client ...");
                var client = this.listener.AcceptSocketAsync().GetAwaiter().GetResult();
                Task.Run(() => this.Listen(client));
            }
        }

        public async Task Listen(Socket client)
        {
            var connectionHandler = new ConnectionHandler(client, this.serverRoutingTable);
            await connectionHandler.ProcessRequestAsync();
        }
    }
}
