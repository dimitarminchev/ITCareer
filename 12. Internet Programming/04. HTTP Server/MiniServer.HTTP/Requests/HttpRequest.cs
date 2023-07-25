﻿using System;
using MiniServer.HTTP.Common;
using MiniServer.HTTP.Enums;
using MiniServer.HTTP.Headers;
using System.Collections.Generic;
using MiniServer.HTTP.Exceptions;
using System.Linq;
using MiniServer.HTTP.Extensions;

namespace MiniServer.HTTP.Requests
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
            if (requestLine.Length == 3 && requestLine[2] == GlobalConstants.HttpOneProtocolFragment)
            {
                return true;
            }
            else return false;
        }

        private bool IsValidRequestQueryString(string queryString, string[] queryParameters)
        {
            CoreValidator.ThrowIfNullOrEmpty(queryString, nameof(queryString));
            return true; 
        }

        private void ParseRequestMethod(string[] requestLine)
        {
            bool parseResult = HttpRequestMethod.TryParse(requestLine[0], true, out HttpRequestMethod method);

            if (!parseResult)
            {
                throw new BadRequestException($"Unsupported Method: {requestLine[0]}");
            }

            this.RequestMethod = method;
        }

        private void ParseRequestUrl(string[] requestLine)
        {
            this.Url = requestLine[1];
        }

        private void ParseRequestPath()
        {
            this.Path = this.Url.Split('?')[0];
        }

        private void ParseHeaders(string[] requestContent)
        {

            requestContent.Select(plainHeader => plainHeader.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToList().ForEach(headerKeyValuePair => this.Headers.AddHeader(new HttpHeader(headerKeyValuePair[0], headerKeyValuePair[1])));
        }

        private void ParseCookies()
        {
            throw new NotImplementedException();
        }

        private void ParseQueryParameters()
        {
            if (!(this.Url.Split('?').Length > 1)) return;
            this.Url.Split('?', '#')[1].Split('&').Select(plainQueryParameter => plainQueryParameter.Split('=')).ToList().ForEach
            (
                queryParameterKeyValuePair => this.QueryData.Add(queryParameterKeyValuePair[0], queryParameterKeyValuePair[1])
            );
        }

        private void ParseFormDataParameters(string formData)
        {
            if(!string.IsNullOrEmpty(formData))
            {
                // TODO: Parse Multiple Parameters By Name
                formData
                    .Split('&')
                    .Select(plainQueryParameter => plainQueryParameter.Split('='))
                    .ToList()
                    .ForEach(queryParameterKeyValuePair =>
                        this.FormData.Add(queryParameterKeyValuePair[0], queryParameterKeyValuePair[1]));
            }
        }

        private void ParseRequestParameters(string formData)
        {
            ParseQueryParameters();
            ParseFormDataParameters(formData);
        }

        private IEnumerable<string> ParsePlainRequestHeaders(string[] requestLines)
        {
            for (int i = 1; i < requestLines.Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(requestLines[i]))
                {
                    yield return requestLines[i];
                }
            }
        }

        private void ParseRequest(string requestString)
        {
            string[] splitRequestContent = requestString.Split(new[] { GlobalConstants.HttpNewLine }, StringSplitOptions.None);

            string[] requestLine = splitRequestContent[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!this.IsValidRequestLine(requestLine))
            {
                throw new BadRequestException();
            }

            this.ParseRequestMethod(requestLine);
            this.ParseRequestUrl(requestLine);
            this.ParseRequestPath();

            this.ParseHeaders(this.ParsePlainRequestHeaders(splitRequestContent).ToArray());
            // this.ParseCookies();

            this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
        }
    }
}
