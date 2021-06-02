

namespace WebServer.Server.Http
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class HttpRequest
    {
        private const string NewLine = "\r\n";
        public HttpMethod Method { get; init; }

        public string Url { get; init; }

        public HttpHeaderCollection Headers { get; private set; }

        public string Body { get; init; }

        public static HttpRequest Parse(string request)
        {
            var lines = request.Split(NewLine);

            var startLine = lines.First().Split(" ");

            var method = ParseHttpMethod(startLine[0]);
            var url = startLine[1];

            var headers = ParseHttpHeaders(lines.Skip(1));

            var bodyLines = lines.Skip(headers.Count + 2).ToArray();
            var body = string.Join(NewLine, bodyLines);

            return new HttpRequest
            {
                Method = method,
                Url = url,
                Headers = headers,
                Body = body,
            };
        }

        public static HttpMethod ParseHttpMethod(string method)
            => method.ToLower() switch
        {
            "GET" => HttpMethod.Get,
            "POST" => HttpMethod.Post,
            "PUT" => HttpMethod.Put,
            "DELETE" => HttpMethod.Delete,
            _ => throw new InvalidOperationException($"Method {method} is not supported."),
        };

        private static HttpHeaderCollection ParseHttpHeaders(IEnumerable<string> headerLines)
        {
            var headerCollection = new HttpHeaderCollection();

            foreach (var headerLine in headerLines)
            {
                if (headerLine == string.Empty)
                {
                    break;
                }

                var indexOfColon = headerLine.IndexOf(":");

                if (indexOfColon < 0)
                {
                    throw new InvalidOperationException("Request is not valid.");
                }

                var header = new HttpHeader()
                {
                    Name = headerLine.Substring(0, indexOfColon),
                    Value = headerLine[(indexOfColon + 1)..].Trim()
                };

                headerCollection.Add(header);
            }

            return headerCollection;
        }


        //private static string[] GetStartLine(string request) 
        //{
            
        
        //}
    }
}
