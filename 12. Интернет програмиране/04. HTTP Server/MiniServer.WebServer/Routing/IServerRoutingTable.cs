using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Requests;
using MiniServer.HTTP.Responses;
using System;

namespace MiniServer.WebServer.Routing
{
    public interface IServerRoutingTable
    {
        void Add(HttpRequestMethod method, string path, Func<IHttpRequest, IHttpResponse> func);

        bool Contains(HttpRequestMethod method, string path);

        Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path);
    }
}
