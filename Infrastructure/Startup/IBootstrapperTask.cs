namespace CompatibleSoftware.Infrastructure.Startup
{
    /// <summary>
    /// A task that runs when the application fires up  
    /// </summary>
    /// <remarks>
    /// <para>
    /// This interface can (and should) be used in any place where you need to execute a task at startup.
    /// </para>
    /// </remarks>
    public interface IBootstrapperTask
    {
        /// <summary>
        /// Executes the task.
        /// </summary>
        void Execute();
    }
}
