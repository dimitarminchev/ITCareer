using MiniServer.HTTP;
using System.Text;

namespace MiniServer.WebServer
{
    public class HtmlResult : HttpResponse
    {
        public HtmlResult
        (
            string content,
            HttpResponseStatusCode responseStatusCode
        ) : base(responseStatusCode)
        {
            this.Headers.AddHeader
            (
                new HttpHeader("Content-Type", 
                "text/html; charset=utf-8")
            );
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
