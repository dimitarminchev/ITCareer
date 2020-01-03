using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Headers;
using MiniServer.HTTP.Responses;

namespace MiniServer.WebServer.Results
{
    public class RedirectResult : HttpResponse
    {
        public RedirectResult(string location) : base(HttpResponseStatusCode.SeeOther)
        {
            this.Headers.AddHeader(new HttpHeader(HttpHeader.Location, location));  
        }
    }
}
