using MiniServer.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.HTTP.Headers
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            return headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            return headers[key];
        }

        public override string ToString() => string.Join(Environment.NewLine,  this.headers.Values.Select(header => header.ToString()));
    }
}
