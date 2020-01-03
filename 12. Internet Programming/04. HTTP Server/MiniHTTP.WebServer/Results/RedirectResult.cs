using MiniHTTP.HTTP.Enums;
using MiniHTTP.HTTP.Headers;
using MiniHTTP.HTTP.Responses;

namespace MiniHTTP.WebServer.Results
{
    public class RedirectResult : HttpResponse
    {
        public RedirectResult(string location) : base(HttpResponseStatusCode.SeeOther)
        {
            this.Headers.AddHeader(new HttpHeader(HttpHeader.Location, location));  
        }
    }
}
