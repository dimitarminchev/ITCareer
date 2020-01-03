using System;
using MiniHTTP.HTTP.Common;
using MiniHTTP.HTTP.Enums;
using MiniHTTP.HTTP.Headers;
using System.Collections.Generic;
using MiniHTTP.HTTP.Exceptions;
using System.Linq;

namespace MiniHTTP.HTTP.Requests
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            CoreValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));

            this.FormData = new Dictionary<string, object>();
            this.QueryData = new Dictionary<string, object>();
            this.Headers = new HttpHeaderCollection();

            this.ParseRequest(requestString);
        }

        public string Path { get; private set; }

        public string Url { get; private set; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public HttpRequestMethod RequestMethod { get; private set; }

        private bool IsValidRequestLine(string[] requestLine)
        {
            throw new NotImplementedException();
        }

        private bool IsValidRequestQueryString(string queryString, string[] queryParameters)
        {
            throw new NotImplementedException();
        }

        private void ParseRequestMethod(string[] requestLine)
        {
            throw new NotImplementedException();
        }

        private void ParseRequestUrl(string[] requestLine)
        {
            throw new NotImplementedException();
        }

        private void ParseRequestPath()
        {
            throw new NotImplementedException();
        }

        private void ParseHeaders(string[] requestContent)
        {
            throw new NotImplementedException();
        }

        private void ParseCookies()
        {
            throw new NotImplementedException();
        }

        private void ParseQueryParameters()
        {
            throw new NotImplementedException();
        }

        private void ParseFormDataParameters(string formData)
        {
            throw new NotImplementedException();
        }

        private void ParseRequestParameters(string formData)
        {
            throw new NotImplementedException();
        }

        private void ParseRequest(string requestString)
        {
            string[] splitRequestContent = requestString.Split(new[] { GlobalConstants.HttpNewLine }, StringSplitOptions.None);
            
            string[] requestLine = splitRequestContent[0].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!this.IsValidRequestLine(requestLine))
            {
                throw new BadRequestException();
            }

            this.ParseRequestMethod(requestLine);
            this.ParseRequestUrl(requestLine);
            this.ParseRequestPath();

            this.ParseHeaders(splitRequestContent.Skip(1).ToArray());
            this.ParseCookies();

            this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
        }
    }
}
