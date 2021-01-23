using MiniServer.HTTP;
using MiniServer.WebServer;
using System.IO;
using System.Text;

namespace MiniServer.Demo
{
    public class HomeController
    {
        // index.html
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = File.ReadAllText("web\\index.html", Encoding.UTF8);
            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        // logo.png
        public IHttpResponse Logo(IHttpRequest request)
        {
            byte[] content = File.ReadAllBytes("Web\\logo.png");
            return new TextResult(content, HttpResponseStatusCode.Ok, "image/png");
        }

        // style.css
        public IHttpResponse Style(IHttpRequest request)
        {
            byte[] content = File.ReadAllBytes("Web\\styles.css");
            return new TextResult(content, HttpResponseStatusCode.Ok, "text/css");
        }
    }
}
