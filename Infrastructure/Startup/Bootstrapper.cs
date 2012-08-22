using System.Linq;
using Microsoft.Practices.ServiceLocation;

namespace CompatibleSoftware.Infrastructure.Startup
{
    /// <summary>
    /// Static class to initialise tasks performed on startup
    /// </summary>
    public static class Bootstrapper
    {
        /// <summary>
        /// Empty static constructor so the class can't be initialised
        /// </summary>
        static Bootstrapper()
        {
        }

        /// <summary>
        /// Runs all startup tasks
        /// </summary>
        public static void Run()
        {
           ServiceLocator.Current.GetAllInstances<IBootstrapperTask>().ToList().ForEach(task => task.Execute());
        }
    }
}
