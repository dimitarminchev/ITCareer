using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniServer.HTTP
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
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            return this.headers.FirstOrDefault(x => x.Key == key).Value;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.headers.Select(x => x.Value));
        }
    }
}
