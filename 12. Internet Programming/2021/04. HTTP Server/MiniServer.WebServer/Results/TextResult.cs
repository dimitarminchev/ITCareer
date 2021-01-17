using MiniServer.HTTP;
using System.Text;

namespace MiniServer.WebServer
{
    public class TextResult : HttpResponse
    {
        public TextResult
        (
            string content, 
            HttpResponseStatusCode responseStatusCode, 
            string contentType = "text/plain; charset=utf-8"
        ) : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader("Content-Type", contentType));
            this.Content = Encoding.UTF8.GetBytes(content);
        }

        public TextResult
        (
            byte[] content,
            HttpResponseStatusCode responseStatusCode,
            string contentType = "text/plain; charset=utf-8"
        ) : base(responseStatusCode)
        {
            this.Content = content;
            this.Headers.AddHeader(new HttpHeader("Content-Type", contentType));
        }
    }
}
