using MiniHTTP.HTTP.Enums;
using MiniHTTP.HTTP.Headers;
using System.Collections.Generic;

namespace MiniHTTP.HTTP.Requests
{
    public interface IHttpRequest
    {
        string Path { get; }
        string Url { get; }
        Dictionary<string, object> FormData { get; }
        Dictionary<string, object> QueryData { get; }
        IHttpHeaderCollection Headers { get; }
        HttpRequestMethod RequestMethod { get; }
    }
}
