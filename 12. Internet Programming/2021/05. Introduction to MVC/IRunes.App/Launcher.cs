using IRunes.App.Controllers;
using MiniServer.HTTP;
using MiniServer.WebServer;
using System.IO;

namespace IRunes.App
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            // Web Server Routing Table
            ServerRoutingTable routes = new ServerRoutingTable();

            // Home
            routes.Add(HttpRequestMethod.Get, "/", request => new RedirectResult("/Home/Index"));
            routes.Add(HttpRequestMethod.Get, "/Home/Index", request => new HomeController().Index(request));

            // Albums
            routes.Add(HttpRequestMethod.Get, "/Albums/All", request => new AlbumsController().All(request));
            routes.Add(HttpRequestMethod.Get, "/Albums/Details", request => new AlbumsController().Details(request));
            routes.Add(HttpRequestMethod.Get, "/Albums/Create", request => new AlbumsController().Create(request));
            routes.Add(HttpRequestMethod.Post, "/Albums/Create", request => new AlbumsController().CreateConfirm(request));

            // Resources
            routes.Add(HttpRequestMethod.Get, "/Home/css/bootstrap.min.css", request => 
              new HtmlResult(File.ReadAllText("Resources/css/bootstrap.min.css"), HttpResponseStatusCode.Ok));
            routes.Add(HttpRequestMethod.Get, "/Home/js/bootstrap.min.js", request => 
              new HtmlResult(File.ReadAllText("Resources/js/bootstrap.min.js"), HttpResponseStatusCode.Ok));
            routes.Add(HttpRequestMethod.Get, "/Home/js/jquery-3.4.1.min.js", request =>
             new HtmlResult(File.ReadAllText("Resources/js/jquery-3.4.1.min.js"), HttpResponseStatusCode.Ok));
            routes.Add(HttpRequestMethod.Get, "/Home/js/popper.min.js", request =>
             new HtmlResult(File.ReadAllText("Resources/js/popper.min.js"), HttpResponseStatusCode.Ok));

            // Web Server
            Server server = new Server(8080, routes);
            server.Run();
        }

    }
}
