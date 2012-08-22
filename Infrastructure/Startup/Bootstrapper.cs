using System.Collections.Generic;
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
            IBootstrapperTasksFactory tasks = new BootstrapperTasksFactory();
            tasks.CreateTasks().ToList().ForEach(x => x.Execute());
        }
    }
}
