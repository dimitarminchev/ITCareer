using MiniServer.HTTP;

namespace IRunes.App.Controllers 
{
    public class AlbumsController : BaseController
    {
        // All.html
        public IHttpResponse All(IHttpRequest httpRequest)
        {
            return this.View();
        }

        // Details.html
        public IHttpResponse Details(IHttpRequest httpRequest)
        {
            return this.View();
        }

        // Create.html
        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }

        // Create.html
        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
