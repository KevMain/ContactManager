using System.Web.Mvc;
using System.Web.Routing;

namespace CompatibleSoftware.Infrastructure.Startup
{
    public class RouteConfig : IBootstrapperTask
    {
        private readonly RouteCollection _routes;

        public RouteConfig()
            : this(RouteTable.Routes)
        {
        }

        public RouteConfig(RouteCollection routes)
        {
            _routes = routes;
        }

        public void Execute()
        {
            _routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            _routes.MapRoute("Default", "{controller}/{action}/{id}", new {controller = "Home", action = "Index", id = UrlParameter.Optional});
        }
    }
}
