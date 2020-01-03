using MiniServer.HTTP.Common;
using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Headers;
using System;
using System.Text;

namespace MiniServer.HTTP.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }

        public HttpResponse(HttpResponseStatusCode statusCode) : this()
        {
            CoreValidator.ThrowIfNull(statusCode, nameof(statusCode));
            this.StatusCode = statusCode;
        }

        public HttpResponseStatusCode StatusCode { get; set; }

        public IHttpHeaderCollection Headers { get; }

        public byte[] Content { get; set; }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            this.Headers.AddHeader(header);
        }

        public byte[] GetBytes()
        {
            var Header = Encoding.UTF8.GetBytes(ToString());
            byte[] Response = new byte[Header.Length + Content.Length];
            Array.Copy(Header, 0, Response, 0, Header.Length);
            Array.Copy(Content, 0, Response, Header.Length, Content.Length);
            return Response;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result
            .Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode.ToString()}")
            .Append(GlobalConstants.HttpNewLine)
            .Append(this.Headers)
            .Append(GlobalConstants.HttpNewLine)
            .Append(GlobalConstants.HttpNewLine);
            return result.ToString();
        }
    }
}
