using MiniHTTP.HTTP.Enums;
using MiniHTTP.HTTP.Requests;
using MiniHTTP.HTTP.Responses;
using MiniHTTP.WebServer.Results;

namespace MiniServer.Demo
{
    public class HomeController
    {
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = "<h1>#1 WEB PAGE</h1><p>The Number One Web Page.</p>";
            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
