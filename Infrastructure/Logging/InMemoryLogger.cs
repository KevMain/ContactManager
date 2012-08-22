using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompatibleSoftware.Infrastructure.Logging
{
    public class InMemoryLogger : ILogger
    {
        public bool IsEnabled(LogLevel level)
        {
            return false;
        }

        public void Log(LogLevel level, Exception exception, string format, params object[] args)
        {
            //nothing
        }
    }
}
