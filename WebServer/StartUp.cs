namespace WebServer
{
    using System.Threading.Tasks;
    using WebServer.Server;
    using WebServer.Controllers;
    using WebServer.Server.Controllers;

    public class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
            .MapGet<HomeController>("/", c => c.Index())
            .MapGet<AnimalsController>("/Cats", c => c.Cats())
            .MapGet<AnimalsController>("/Dogs", c => c.Dogs()))
            .Start();
    }
}
