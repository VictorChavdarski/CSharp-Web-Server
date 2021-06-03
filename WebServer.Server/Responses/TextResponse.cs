﻿namespace WebServer.Server.Responses
{
    using System.Text;
    using WebServer.Server.Common;
    using WebServer.Server.Http;

    public class TextResponse : HttpResponse
    {
        public TextResponse(string text, string contentType)
            :base(HttpStatusCode.OK)
        {
            Guard.AgainstNull(text);

            var contentLength = Encoding.UTF8.GetByteCount(text).ToString();

            this.Headers.Add("Content-Length", contentLength);
            this.Headers.Add("Content-Type", contentType);

            this.Content = text;
        }

        public TextResponse(string text)
        : this(text, "text/plain; charset=utf-8")
        {
        }
    }
}
