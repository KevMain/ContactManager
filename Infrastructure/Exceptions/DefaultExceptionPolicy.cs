using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using CompatibleSoftware.Infrastructure.Logging;
using CompatibleSoftware.Infrastructure.Security;
using CompatibleSoftware.Infrastructure.UI.Notify;

namespace CompatibleSoftware.Infrastructure.Exceptions
{
    public class DefaultExceptionPolicy : IExceptionPolicy
    {
        public ILogger Log { get; set; }
        private readonly INotifier _notifier;

        public DefaultExceptionPolicy()
        {
            Log = Logger.Instance;
        }

        public DefaultExceptionPolicy(INotifier notifier)
        {
            _notifier = notifier;
            Log = Logger.Instance;
        }

        public bool HandleException(object sender, Exception exception)
        {
            if (IsFatal(exception))
            {
                return false;
            }

            Log.Error(exception, "An unexpected exception was caught");

            do
            {
                RaiseNotification(exception);
                exception = exception.InnerException;
            } while (exception != null);

            return true;
        }

        private static bool IsFatal(Exception exception)
        {
            return
                exception is CustomSecurityException ||
                exception is CustomFatalException ||
                exception is StackOverflowException ||
                exception is AccessViolationException ||
                exception is AppDomainUnloadedException ||
                exception is ThreadAbortException ||
                exception is SecurityException ||
                exception is SEHException;
        }

        private void RaiseNotification(Exception exception)
        {
            if (_notifier == null)
            {
                return;
            }
            if (exception is CustomException)
            {
                _notifier.Error((exception as CustomException).LocalizedMessage);
            }
            else
            {
                _notifier.Error(exception.Message);
            }
        }
    }
}
