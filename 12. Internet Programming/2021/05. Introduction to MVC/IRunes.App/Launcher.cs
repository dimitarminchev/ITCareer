using IRunes.App.Controllers;
using MiniServer.HTTP;
using MiniServer.WebServer;

namespace IRunes.App
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            ServerRoutingTable routes = new ServerRoutingTable();

            // Home
            routes.Add(HttpRequestMethod.Get, "/", request => new RedirectResult("/Home/Index"));
            routes.Add(HttpRequestMethod.Get, "/Home/Index", request => new HomeController().Index(request));

            // Albums
            routes.Add(HttpRequestMethod.Get, "/Albums/All", request => new AlbumsController().All(request));
            routes.Add(HttpRequestMethod.Get, "/Albums/Details", request => new AlbumsController().Details(request));
            routes.Add(HttpRequestMethod.Get, "/Albums/Create", request => new AlbumsController().Create(request));
            routes.Add(HttpRequestMethod.Post, "/Albums/Create", request => new AlbumsController().CreateConfirm(request));

            Server server = new Server(8000, routes);
            server.Run();
        }

    }
}
