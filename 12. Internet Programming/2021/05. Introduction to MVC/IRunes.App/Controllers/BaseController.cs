using MiniServer.HTTP;
using MiniServer.WebServer;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace IRunes.App.Controllers
{
    public abstract class BaseController
    {
        // Data
        protected Dictionary<string, object> ViewData;
        
        // Constructor
        protected BaseController()
        {
            this.ViewData = new Dictionary<string, object>();
        }

        // Parse
        private string ParseTemplate(string viewContent)
        {
            foreach (var param in this.ViewData)
            {
                viewContent = viewContent.Replace($"@Model.{param.Key}", param.Value.ToString());
            }
            return viewContent;
        }

        // View
        protected IHttpResponse View([CallerMemberName] string view = null)
        {
            string controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            string viewName = view;
            string viewContent = File.ReadAllText("Views/" + controllerName + "/" + viewName + ".html");
            viewContent = this.ParseTemplate(viewContent);
            HtmlResult htmlResult = new HtmlResult(viewContent, HttpResponseStatusCode.Ok);
            return htmlResult;
        }

        // Redirect
        protected IHttpResponse Redirect(string url)
        {
            return new RedirectResult(url);
        }
    }
}
