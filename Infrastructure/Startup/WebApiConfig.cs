using System.Web.Http;

namespace CompatibleSoftware.Infrastructure.Startup
{
    public class WebApiConfig : IBootstrapperTask
    {
        private readonly HttpConfiguration _httpConfiguration;

        public WebApiConfig()
            : this(GlobalConfiguration.Configuration)
        {
        }

        public WebApiConfig(HttpConfiguration routes)
        {
            _httpConfiguration = routes;
        }

        public void Execute()
        {
            _httpConfiguration.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}
