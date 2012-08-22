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

            _routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
