using MiniServer.HTTP.Requests;
using MiniServer.HTTP.Responses;

namespace IRunes.App.Controllers
{
    public class AlbumsController : BaseController
    {
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return View("All");
        }

        public IHttpResponse Details(IHttpRequest httpRequest)
        {
            return View("Details");
        }

        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return base.View("Create");
        }

        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return base.View("Create");
        }
    }
}
