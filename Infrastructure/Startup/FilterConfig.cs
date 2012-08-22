using System.Web.Mvc;

namespace CompatibleSoftware.Infrastructure.Startup
{
    public class FilterConfig : IBootstrapperTask
    {

        private readonly GlobalFilterCollection _filters;

        public FilterConfig()
            : this(GlobalFilters.Filters)
        {
        }

        public FilterConfig(GlobalFilterCollection filters)
        {
            _filters = filters;
        }

        public void Execute()
        {
            _filters.Add(new HandleErrorAttribute());
        }
    }
}
