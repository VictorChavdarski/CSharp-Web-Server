﻿using WebServer.Server;
using WebServer.Server.Http;
using WebServer.Server.Responses;

namespace WebServer.Controllers
{
    public class AnimalsController : Controller
    {
        public AnimalsController(HttpRequest request)
            : base(request)
        {
        }

        public HttpResponse Cats()
        {
            const string nameKey = "Name";

            var query = this.Request.Query;
            var catName = query.ContainsKey(nameKey)
            ? query[nameKey]
            : "the cats";

            var result = $"<h1> Hello from {catName}!<h1>";

            return Html(result);
        }

        public HttpResponse Dogs()
          => Html("<h1>Hello from the dogs!<h1>");

    }
}
