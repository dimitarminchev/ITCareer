using System;
using MiniServer.HTTP;
using MiniServer.WebServer;

namespace MiniServer.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            // Create Web Routing Table
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            // index.html
            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                "/",
                request => new HomeController().Index(request) 
            );

            // logo.png
            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                path: "/logo.png",
                request => new HomeController().Logo(request)
            );

            // styles.css
            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                path: "/styles.css",
                request => new HomeController().Style(request)
            );

            // Start Web Server
            Server server = new Server(8080, serverRoutingTable);
            server.Run();
        }
    }
}
