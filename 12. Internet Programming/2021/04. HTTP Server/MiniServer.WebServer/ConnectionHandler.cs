using MiniServer.HTTP;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.WebServer
{
    public class ConnectionHandler
    {
        private readonly Socket client;

        private readonly IServerRoutingTable serverRoutingTable;

        public ConnectionHandler(Socket client, IServerRoutingTable serverRoutingTable)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(serverRoutingTable, nameof(serverRoutingTable));
            this.client = client;
            this.serverRoutingTable = serverRoutingTable;
        }

        public async Task ProcessRequestAsync()
        {
            IHttpResponse httpResponse = null;

            try
            {
                IHttpRequest httpRequest = await ReadRequest();

                if (httpRequest != null)
                {
                    Console.WriteLine($"Processing: {httpRequest.RequestMethod} {httpRequest.Path}...");

                    httpResponse = this.HandleRequest(httpRequest);
                }
            }
            catch (BadRequestException e)
            {
                httpResponse = new TextResult(e.Message, HttpResponseStatusCode.BadRequest);
            }
            catch (Exception e)
            {
                httpResponse = new TextResult(e.Message, HttpResponseStatusCode.InternalServerError);
            }

            await PrepareResponse(httpResponse);
            this.client.Shutdown(SocketShutdown.Both);
        }

        private async Task<IHttpRequest> ReadRequest()
        {
            var result = new StringBuilder();
            var data = new ArraySegment<byte>(new byte[1024]);
            while (true)
            {
                int numberOfBytesRead = await this.client.ReceiveAsync(data.Array, SocketFlags.None);
                if (numberOfBytesRead == 0)
                {
                    break;
                }
                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
                result.Append(bytesAsString);
                if (numberOfBytesRead < 1023)
                {
                    break;
                }
            }
            if (result.Length == 0)
            {
                return null;
            }
            return new HttpRequest(result.ToString());
        }

        private IHttpResponse HandleRequest(IHttpRequest httpRequest)
        {
            if (!this.serverRoutingTable.Contains(httpRequest.RequestMethod, httpRequest.Path))
            {
                return new TextResult($"Route with method {httpRequest.RequestMethod} and path \"{httpRequest.Path}\" not found.", HttpResponseStatusCode.NotFound);
            }
            return this.serverRoutingTable.Get(httpRequest.RequestMethod, httpRequest.Path).Invoke(httpRequest);
        }

        private async Task PrepareResponse(IHttpResponse httpResponse)
        {
            byte[] byteSegments = httpResponse.GetBytes();
            await this.client.SendAsync(byteSegments, SocketFlags.None);
        }
    }
}
