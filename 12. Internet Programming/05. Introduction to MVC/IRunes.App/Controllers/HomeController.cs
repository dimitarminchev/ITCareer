using MiniServer.HTTP.Requests;
using MiniServer.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Controllers
{
    public class HomeController : BaseController
    {
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return base.View("Index");
        }
    }
}
