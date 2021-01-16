using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Requests;
using MiniServer.HTTP.Responses;
using MiniServer.WebServer.Results;
using System.IO;
using System.Text;

namespace MiniServer.Demo
{
    public class HomeController
    {
        /// <summary>
        /// HTML
        /// </summary>
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = File.ReadAllText("Web\\index.html", Encoding.UTF8);
            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        /// <summary>
        /// CSS
        /// </summary>
        public IHttpResponse Styles(IHttpRequest request)
        {
            string content = File.ReadAllText("Web\\styles.css", Encoding.UTF8);
            return new TextResult(content, HttpResponseStatusCode.Ok, "text/css");
        }

        /// <summary>
        /// PNG
        /// </summary>
        public IHttpResponse Logo(IHttpRequest request)
        {
            byte[] content = File.ReadAllBytes("Web\\logo.png");
            return new TextResult(content, HttpResponseStatusCode.Ok, "image/png");
        }
    }
}
