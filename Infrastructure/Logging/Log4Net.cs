using System;
using System.Globalization;
using log4net;
using log4net.Util;

namespace CompatibleSoftware.Infrastructure.Logging
{
    public class Log4Net : ILogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4Net));

        public bool IsEnabled(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return log.IsDebugEnabled;
                case LogLevel.Fatal:
                    return log.IsFatalEnabled;
                case LogLevel.Error:
                    return log.IsErrorEnabled;
                case LogLevel.Information:
                    return log.IsInfoEnabled;
                case LogLevel.Warning:
                    return log.IsWarnEnabled;
            }

            return true;
        }

        public void Log(LogLevel level, Exception exception, string format, params object[] args)
        {
            SystemStringFormat message = new SystemStringFormat(CultureInfo.InvariantCulture, format, args);

            switch (level)
            {
                case LogLevel.Debug:
                    log.Debug(message, exception);
                    break;
                case LogLevel.Fatal:
                    log.Fatal(message, exception);
                    break;
                case LogLevel.Error:
                    log.Error(message, exception);
                    break;
                case LogLevel.Information:
                    log.Info(message, exception);
                    break;
                case LogLevel.Warning:
                    log.Warn(message, exception);
                    break;
            }
            
        }
    }
}
