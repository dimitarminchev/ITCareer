using MiniServer.HTTP.Enums;
using MiniServer.WebServer;
using MiniServer.WebServer.Routing;
using System;

namespace MiniServer.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                path: "/",
                request => new HomeController().Index(request)
            );
            Server server = new Server(port: 8080, serverRoutingTable);
            server.Run();
        }
    }
}
