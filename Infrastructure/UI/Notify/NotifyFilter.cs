using System;

namespace CompatibleSoftware.Infrastructure.UI.Notify
{
    public enum NotifyType
    {
        Information,
        Warning,
        Error
    }

    public class NotifyEntry
    {
        public NotifyType Type { get; set; }
        public String Message { get; set; }
    }
}
