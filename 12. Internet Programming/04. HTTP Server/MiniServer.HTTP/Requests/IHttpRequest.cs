using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Headers;
using System.Collections.Generic;

namespace MiniServer.HTTP.Requests
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
