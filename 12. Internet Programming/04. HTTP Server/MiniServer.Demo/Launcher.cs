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
            // Create Web Routing Table
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add
            (
                HttpRequestMethod.Get, 
                path: "/", 
                request => new HomeController().Index(request)
            );

            serverRoutingTable.Add
            (
                HttpRequestMethod.Get, 
                path: "/styles.css", 
                request => new HomeController().Styles(request)
            );

            serverRoutingTable.Add
            (
                HttpRequestMethod.Get, 
                path: "/logo.png", 
                request => new HomeController().Logo(request)
            );

            // Start Web Server
            Server server = new Server(port: 8080, serverRoutingTable);
            server.Run();
        }
    }
}
