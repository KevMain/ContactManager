using System.Linq;
using CompatibleSoftware.Infrastructure.Startup;
using Microsoft.Practices.ServiceLocation;

namespace CompatibleSoftware.Infrastructure
{
    /// <summary>
    /// Static class to initialise tasks performed on startup
    /// </summary>
    public static class Bootstrapper
    {
        static Bootstrapper()
        {
        }

        public static void Run()
        {
           ServiceLocator.Current.GetAllInstances<IBootstrapperTask>().ToList().ForEach(task => task.Execute());
        }
    }
}
