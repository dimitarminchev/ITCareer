﻿using MiniServer.HTTP.Common;
using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Requests;
using MiniServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.WebServer.Routing
{
    public class ServerRoutingTable : IServerRoutingTable
    {
        private Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>> routingTable;
        public ServerRoutingTable()
        {
            this.routingTable = new Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>>
            {
                [HttpRequestMethod.Get] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Post] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Put] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Delete] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>()
            };
        }

        public void Add(HttpRequestMethod method, string path, Func<IHttpRequest, IHttpResponse> func)
        {
            CoreValidator.ThrowIfNull(method, nameof(method));
            CoreValidator.ThrowIfNullOrEmpty(path, nameof(path));
            CoreValidator.ThrowIfNull(func, nameof(func));

            this.routingTable[method].Add(path, func);
        }

        public bool Contains(HttpRequestMethod method, string path)
        {
            CoreValidator.ThrowIfNull(method, nameof(method));
            CoreValidator.ThrowIfNullOrEmpty(path, nameof(path));

            return this.routingTable.ContainsKey(method) && this.routingTable[method].ContainsKey(path);
        }

        public Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod method, string path)
        {
            CoreValidator.ThrowIfNull(method, nameof(method));
            CoreValidator.ThrowIfNullOrEmpty(path, nameof(path));

            return this.routingTable[method][path];
        }
    }
}
