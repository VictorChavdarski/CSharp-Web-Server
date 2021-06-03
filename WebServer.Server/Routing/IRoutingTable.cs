namespace WebServer.Server.Routing
{
    using WebServer.Server.Http;

    public interface IRoutingTable
    {
        IRoutingTable Map(string url, HttpMethod method, HttpResponse response);

        IRoutingTable MapGet(string url, HttpResponse response);
    }
}
