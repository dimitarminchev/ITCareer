using IRunes.App.Controllers;
using MiniServer.HTTP.Enums;
using MiniServer.WebServer;
using MiniServer.WebServer.Results;
using MiniServer.WebServer.Routing;
using System;

namespace IRunes.App
{
    class Launcher
    {
        public static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(HttpRequestMethod.Get, "/", request => new RedirectResult("/Home/Test"));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/Test", request => new HomeController().Test(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/Index", request => new HomeController().Index(request));

            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All", request => new AlbumsController().All(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Details", request => new AlbumsController().Details(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Create", request => new AlbumsController().Create(request));
            serverRoutingTable.Add(HttpRequestMethod.Post, "/Albums/Create", request => new AlbumsController().CreateConfirm(request));

            Server server = new Server(8080, serverRoutingTable);
            server.Run();
        }
    }
}