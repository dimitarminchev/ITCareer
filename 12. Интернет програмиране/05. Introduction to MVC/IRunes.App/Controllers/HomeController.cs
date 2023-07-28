using MiniServer.HTTP;

namespace IRunes.App.Controllers
{
    public class HomeController : BaseController
    {
        // Index.html
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
