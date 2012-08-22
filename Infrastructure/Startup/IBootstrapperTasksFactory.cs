using System.Collections.Generic;

namespace CompatibleSoftware.Infrastructure.Startup
{
    /// <summary>
    /// Main interface for the factory pattern which creates tasks to run at startup
    /// </summary>
    public interface IBootstrapperTasksFactory
    {
        /// <summary>
        /// Create the tasks for this instance
        /// </summary>
        /// <returns></returns>
        IList<IBootstrapperTask> CreateTasks();
    }
}
