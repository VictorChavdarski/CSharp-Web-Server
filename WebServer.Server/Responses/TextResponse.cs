namespace WebServer.Server.Responses
{
    using System.Text;
    using WebServer.Server.Common;
    using WebServer.Server.Http;

    public class TextResponse : ContentResponse
    {
      

        public TextResponse(string text)
        : base(text, "text/plain; charset=utf-8")
        {
        }
    }
}
