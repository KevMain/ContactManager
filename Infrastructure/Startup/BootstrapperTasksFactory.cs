using System.Collections.Generic;

namespace CompatibleSoftware.Infrastructure.Startup
{
    public class BootstrapperTasksFactory : IBootstrapperTasksFactory
    {
        public IList<IBootstrapperTask> CreateTasks()
        {
            IList<IBootstrapperTask> _tasks = new List<IBootstrapperTask>();
            _tasks.Add(new FilterConfig());
            _tasks.Add(new RegisterAreas());
            _tasks.Add(new RouteConfig());
            _tasks.Add(new WebApiConfig());

            return _tasks;
        }
    }
}
