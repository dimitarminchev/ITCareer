using MiniHTTP.HTTP.Common;
using MiniHTTP.HTTP.Requests;
using MiniHTTP.HTTP.Responses;
using MiniHTTP.WebServer.Routing;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace MiniHTTP.WebServer
{
    public class ConnectionHandler
    {
        private readonly Socket client;

        private readonly IServerRoutingTable serviceRoutingTable;

        public ConnectionHandler(Socket client, IServerRoutingTable serviceRoutingTable)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(serviceRoutingTable, nameof(serviceRoutingTable));
            this.client = client;
            this.serviceRoutingTable = serviceRoutingTable;
        }
        
        public void ProcessRequest()
        {
            try 
            { 
            }
        }

        private IHttpRequest ReadRequest()
        { 
        }

        private IHttpResponse HandleResponse(IHttpRequest httpRequest)
        { 
        }

        private void PrepareResponse(IHttpResponse httpResponse)
        { 
        }

    }
}
