using System;

namespace CompatibleSoftware.Infrastructure.Logging
{
    /// <summary>
    /// Public enum defining level of debugging to use
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Information,
        Warning,
        Error,
        Fatal
    }

    /// <summary>
    /// Main logging interface
    /// </summary>
    public interface ILogger
    {
        bool IsEnabled(LogLevel level);
        void Log(LogLevel level, Exception exception, string format, params object[] args);
    }
}
