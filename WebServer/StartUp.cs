namespace WebServer
{
    using WebServer.Server;
    using System.Threading.Tasks;
    using WebServer.Server.Responses;

    public class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
            .MapGet("/", new TextResponse("Hello from the server!"))
            .MapGet("/Cats", new TextResponse("<h1>Hello from the server!<h1>", "text/html"))
            .MapGet("/Dogs", new TextResponse("<h1>Hello from the dogs!<h1>", "text/html")))
            .Start();
    }
}
