namespace WebServer.Controllers
{
    using WebServer.Server;
    using WebServer.Server.Http;
    using WebServer.Server.Responses;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            : base(request)
        {
        }

        public HttpResponse Index()
           => Text("Hello from the server!");

    }
}
