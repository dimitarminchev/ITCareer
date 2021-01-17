using System;
using MiniServer.HTTP;
using MiniServer.WebServer;

namespace MiniServer.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            // Routes
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                "/",
                request => new HomeController().Index(request) 
            );

            // Server
            Server server = new Server(8080, serverRoutingTable);
            server.Run();
        }
    }
}
