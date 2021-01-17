using MiniServer.HTTP;
using MiniServer.WebServer;

namespace MiniServer.Demo
{
    public class HomeController
    {
        public IHttpResponse Index(IHttpRequest request)
        {
            string html = "<h1>Hello World!</h1>";
            return new HtmlResult(html, HttpResponseStatusCode.Ok);
        }
    }
}
