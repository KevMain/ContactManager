using System;

namespace CompatibleSoftware.Infrastructure.UI.Notify
{
    public static class NotifierExtensions
    {
        /// <summary>
        /// Adds a new UI notification of type Information
        /// </summary>
        /// <param name="message">A localized message to display</param>
        public static void Information(this INotifier notifier, String message)
        {
            notifier.Add(NotifyType.Information, message);
        }

        /// <summary>
        /// Adds a new UI notification of type Warning
        /// </summary>
        /// <param name="message">A localized message to display</param>
        public static void Warning(this INotifier notifier, String message)
        {
            notifier.Add(NotifyType.Warning, message);
        }

        /// <summary>
        /// Adds a new UI notification of type Error
        /// </summary>
        /// <param name="message">A localized message to display</param>
        public static void Error(this INotifier notifier, String message)
        {
            notifier.Add(NotifyType.Error, message);
        }
    }
}
