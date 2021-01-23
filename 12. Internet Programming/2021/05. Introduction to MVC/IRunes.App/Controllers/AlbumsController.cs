using MiniServer.HTTP;

namespace IRunes.App.Controllers 
{
    public class AlbumsController : BaseController
    {
        public IHttpResponse All(IHttpRequest httpRequest)
        {
            return this.View();
        }

        public IHttpResponse Details(IHttpRequest httpRequest)
        {
            return this.View();
        }

        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }

        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
