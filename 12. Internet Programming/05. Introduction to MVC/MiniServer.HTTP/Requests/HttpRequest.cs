using System;
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
            //if (!string.IsNullOrEmpty(queryString) && queryParameters.Length >= 1)
            //{
            //    return true;
            //}
            //else return false;

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
            // this.Path = this.Url.Split(new[] { '?', '#' }, StringSplitOptions.RemoveEmptyEntries)[0];
            this.Path = this.Url.Split('?')[0];
        }

        private void ParseHeaders(string[] requestContent)
        {
            //for (int i = 0; i < requestContent.Length; i++)
            //{
            //    if (string.IsNullOrEmpty(requestContent[i].Trim()))
            //    {
            //        break;
            //    }
            //    string[] keyValueArr = requestContent[i].Split(new char[] { ':' });

            //    HttpHeader headerToAdd = new HttpHeader(keyValueArr[0], keyValueArr[1].Trim());
            //    this.Headers.AddHeader(headerToAdd);
            //}

            //if (!Headers.ContainsHeader("Host"))
            //{
            //    throw new BadRequestException();
            //}

            requestContent.Select(plainHeader => plainHeader.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToList().ForEach(headerKeyValuePair => this.Headers.AddHeader(new HttpHeader(headerKeyValuePair[0], headerKeyValuePair[1])));
        }

        private void ParseCookies()
        {
            throw new NotImplementedException();
        }

        private void ParseQueryParameters()
        {
            //int indexOfQuestionMark = this.Url.IndexOf('?');
            //if (indexOfQuestionMark == -1)
            //{
            //    return;
            //}

            //int indexOfAnchor = this.Url.IndexOf('#');
            //if (indexOfAnchor == -1) indexOfAnchor = this.Url.Length - 1;

            //string queryString = this.Url.Substring(indexOfQuestionMark, indexOfAnchor - indexOfQuestionMark + 1);
            //string[] queryParameters = queryString.Split(new char[] { '&', '#', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //if (!IsValidRequestQueryString(queryString, queryParameters))
            //{
            //    throw new BadRequestException();
            //}

            //for (int i = 0; i < queryParameters.Length; i++)
            //{
            //    string[] keyValueArr = queryParameters[i].Split('=').ToArray();
            //    QueryData.Add(keyValueArr[0], keyValueArr[1]);
            //}

            if (!(this.Url.Split('?').Length > 1)) return;
            this.Url.Split('?', '#')[1].Split('&').Select(plainQueryParameter => plainQueryParameter.Split('=')).ToList().ForEach
            (
                queryParameterKeyValuePair => this.QueryData.Add(queryParameterKeyValuePair[0], queryParameterKeyValuePair[1])
            );
        }

        private void ParseFormDataParameters(string formData)
        {
            //formData.Trim();
            //if (!string.IsNullOrEmpty(formData))
            //{
            //    string[] pairs = formData.Split('&').ToArray();
            //    for (int i = 0; i < pairs.Length; i++)
            //    {
            //        string currentPair = pairs[i];
            //        string[] pairArray = currentPair.Split('=').ToArray();
            //        this.FormData.Add(pairArray[0], pairArray[1]);
            //    }
            //}

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
            //this.ParseHeaders(splitRequestContent.Skip(1).ToArray());
            // this.ParseCookies();

            this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
        }
    }
}
